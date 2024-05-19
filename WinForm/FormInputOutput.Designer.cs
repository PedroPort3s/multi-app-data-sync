namespace WinForm
{
    partial class FormInputOutput
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubmit = new Button();
            txtInput = new TextBox();
            txtOutput = new TextBox();
            lbInput = new Label();
            lbOutput = new Label();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(222, 95);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 0;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += this.btnSubmit_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(22, 30);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(275, 59);
            txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(22, 132);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(275, 111);
            txtOutput.TabIndex = 2;
            // 
            // lbInput
            // 
            lbInput.AutoSize = true;
            lbInput.Location = new Point(22, 12);
            lbInput.Name = "lbInput";
            lbInput.Size = new Size(35, 15);
            lbInput.TabIndex = 3;
            lbInput.Text = "Input";
            // 
            // lbOutput
            // 
            lbOutput.AutoSize = true;
            lbOutput.Location = new Point(22, 114);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(45, 15);
            lbOutput.TabIndex = 4;
            lbOutput.Text = "Output";
            // 
            // FormInputOutput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 255);
            Controls.Add(lbOutput);
            Controls.Add(lbInput);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Controls.Add(btnSubmit);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormInputOutput";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Input and Output";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private TextBox txtInput;
        private TextBox txtOutput;
        private Label lbInput;
        private Label lbOutput;
    }
}
