using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    public partial class form_counter : Form
    {
        public form_counter()
        {
            InitializeComponent();
            progress_bar1.Visible = false;
            label_result.Visible = false;

        }

        private async void button_submit_ClickAsync(object sender, EventArgs e)
        {

            int number = (int) numeric_input.Value;
            
            progress_bar1.Value = 0;
            progress_bar1.Maximum = number;
            progress_bar1.Visible = true;
            progress_bar1.Step = 1;

            int result = await Task.Run(async () => await calculateResultAsync(number));
            
            label_result.Text = "result: " + result.ToString();
            label_result.Visible = true;

            await Task.Delay(500);
            progress_bar1.Visible = false ;
         }
        public delegate void UpdateProgressBarDelegate();

        private async Task<int> calculateResultAsync(int number)
        {
            int sum = 0;

            for (int i = 0; i <= number; i++)
            {
                sum += i;
                await Task.Delay(500);

                InvokeUpdateProgrssBar();
            }
            return sum;
        }

        public void InvokeUpdateProgrssBar()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new UpdateProgressBarDelegate(UpdateProgressBar));
            }
            else
            {
                UpdateProgressBar();
            }
        }

        private void UpdateProgressBar()
        {
            progress_bar1.PerformStep();
        }

    }
}
