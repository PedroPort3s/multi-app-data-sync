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
            txtServerAddress = new TextBox();
            btnConnect = new Button();
            lbServerIp = new Label();
            pnlInputOutput = new Panel();
            listBoxOutput = new ListBox();
            lbOutput = new Label();
            lbInput = new Label();
            txtInput = new TextBox();
            btnSubmit = new Button();
            btnDisconnect = new Button();
            pnlInputOutput.SuspendLayout();
            SuspendLayout();
            // 
            // txtServerAddress
            // 
            txtServerAddress.Location = new Point(36, 24);
            txtServerAddress.Name = "txtServerAddress";
            txtServerAddress.Size = new Size(191, 23);
            txtServerAddress.TabIndex = 5;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(233, 24);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // lbServerIp
            // 
            lbServerIp.AutoSize = true;
            lbServerIp.Location = new Point(36, 6);
            lbServerIp.Name = "lbServerIp";
            lbServerIp.Size = new Size(133, 15);
            lbServerIp.TabIndex = 8;
            lbServerIp.Text = "Server address with port";
            // 
            // pnlInputOutput
            // 
            pnlInputOutput.Controls.Add(listBoxOutput);
            pnlInputOutput.Controls.Add(lbOutput);
            pnlInputOutput.Controls.Add(lbInput);
            pnlInputOutput.Controls.Add(txtInput);
            pnlInputOutput.Controls.Add(btnSubmit);
            pnlInputOutput.Dock = DockStyle.Bottom;
            pnlInputOutput.Location = new Point(0, 53);
            pnlInputOutput.Name = "pnlInputOutput";
            pnlInputOutput.Size = new Size(435, 376);
            pnlInputOutput.TabIndex = 10;
            // 
            // listBoxOutput
            // 
            listBoxOutput.FormattingEnabled = true;
            listBoxOutput.HorizontalScrollbar = true;
            listBoxOutput.ItemHeight = 15;
            listBoxOutput.Location = new Point(36, 133);
            listBoxOutput.Name = "listBoxOutput";
            listBoxOutput.Size = new Size(353, 214);
            listBoxOutput.TabIndex = 11;
            // 
            // lbOutput
            // 
            lbOutput.AutoSize = true;
            lbOutput.Location = new Point(36, 115);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(45, 15);
            lbOutput.TabIndex = 9;
            lbOutput.Text = "Output";
            // 
            // lbInput
            // 
            lbInput.AutoSize = true;
            lbInput.Location = new Point(36, 13);
            lbInput.Name = "lbInput";
            lbInput.Size = new Size(35, 15);
            lbInput.TabIndex = 8;
            lbInput.Text = "Input";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(36, 31);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(353, 59);
            txtInput.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(314, 96);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(314, 24);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(75, 23);
            btnDisconnect.TabIndex = 11;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // FormInputOutput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 429);
            Controls.Add(btnDisconnect);
            Controls.Add(pnlInputOutput);
            Controls.Add(lbServerIp);
            Controls.Add(btnConnect);
            Controls.Add(txtServerAddress);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormInputOutput";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Input and Output";
            FormClosing += FormInputOutput_FormClosing;
            pnlInputOutput.ResumeLayout(false);
            pnlInputOutput.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtServerAddress;
        private Button btnConnect;
        private Label lbServerIp;
        private Panel pnlInputOutput;
        private Label lbOutput;
        private Label lbInput;
        private TextBox txtOutput;
        private TextBox txtInput;
        private Button btnSubmit;
        private ListBox listBoxOutput;
        private Button btnDisconnect;
    }
}
