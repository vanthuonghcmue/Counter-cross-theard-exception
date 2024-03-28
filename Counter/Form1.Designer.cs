namespace Counter
{
    partial class form_counter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numeric_input = new System.Windows.Forms.NumericUpDown();
            this.label_number = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.progress_bar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_input)).BeginInit();
            this.SuspendLayout();
            // 
            // numeric_input
            // 
            this.numeric_input.Location = new System.Drawing.Point(279, 143);
            this.numeric_input.Name = "numeric_input";
            this.numeric_input.Size = new System.Drawing.Size(120, 20);
            this.numeric_input.TabIndex = 0;
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(227, 148);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(44, 13);
            this.label_number.TabIndex = 2;
            this.label_number.Text = "Number";
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(460, 143);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(75, 23);
            this.button_submit.TabIndex = 3;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_ClickAsync);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(364, 289);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(37, 13);
            this.label_result.TabIndex = 4;
            this.label_result.Text = "Result";
            // 
            // progress_bar1
            // 
            this.progress_bar1.Location = new System.Drawing.Point(230, 232);
            this.progress_bar1.Name = "progress_bar1";
            this.progress_bar1.Size = new System.Drawing.Size(305, 23);
            this.progress_bar1.TabIndex = 5;
            // 
            // form_counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progress_bar1);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.numeric_input);
            this.Name = "form_counter";
            this.Text = "Counter";
            ((System.ComponentModel.ISupportInitialize)(this.numeric_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numeric_input;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.ProgressBar progress_bar1;
    }
}

