namespace CertificateEncoder.Forms
{
    partial class MainFrm
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
            btnGenCert = new Button();
            lblCrtPath = new Label();
            txtCrtPath = new TextBox();
            btnCert = new Button();
            btnEncrypt = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblInput = new Label();
            txtInput = new TextBox();
            txtExit = new TextBox();
            lblExit = new Label();
            btnDecrypt = new Button();
            SuspendLayout();
            // 
            // btnGenCert
            // 
            btnGenCert.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGenCert.Location = new Point(12, 351);
            btnGenCert.Name = "btnGenCert";
            btnGenCert.Size = new Size(102, 23);
            btnGenCert.TabIndex = 6;
            btnGenCert.Text = "Gerar certificado";
            btnGenCert.UseVisualStyleBackColor = true;
            btnGenCert.Click += OnGenCertClick;
            // 
            // lblCrtPath
            // 
            lblCrtPath.AutoSize = true;
            lblCrtPath.Location = new Point(12, 9);
            lblCrtPath.Name = "lblCrtPath";
            lblCrtPath.Size = new Size(132, 15);
            lblCrtPath.TabIndex = 7;
            lblCrtPath.Text = "Caminho do certificado";
            // 
            // txtCrtPath
            // 
            txtCrtPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCrtPath.Location = new Point(14, 27);
            txtCrtPath.Name = "txtCrtPath";
            txtCrtPath.ReadOnly = true;
            txtCrtPath.Size = new Size(279, 23);
            txtCrtPath.TabIndex = 8;
            // 
            // btnCert
            // 
            btnCert.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCert.Location = new Point(299, 26);
            btnCert.Name = "btnCert";
            btnCert.Size = new Size(59, 23);
            btnCert.TabIndex = 9;
            btnCert.Text = "Abrir";
            btnCert.UseVisualStyleBackColor = true;
            btnCert.Click += OnBrnCertClick;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEncrypt.Location = new Point(154, 351);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(92, 23);
            btnEncrypt.TabIndex = 10;
            btnEncrypt.Text = "Criptografar";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += OnEncryptClick;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(12, 83);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(346, 23);
            txtPassword.TabIndex = 12;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(10, 65);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(115, 15);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Senha do certificado";
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(14, 143);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(47, 15);
            lblInput.TabIndex = 13;
            lblInput.Text = "Entrada";
            // 
            // txtInput
            // 
            txtInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtInput.Location = new Point(14, 161);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(344, 69);
            txtInput.TabIndex = 14;
            // 
            // txtExit
            // 
            txtExit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtExit.Location = new Point(14, 259);
            txtExit.Multiline = true;
            txtExit.Name = "txtExit";
            txtExit.ReadOnly = true;
            txtExit.Size = new Size(344, 69);
            txtExit.TabIndex = 16;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Location = new Point(14, 241);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(35, 15);
            lblExit.TabIndex = 15;
            lblExit.Text = "Saída";
            // 
            // btnDecrypt
            // 
            btnDecrypt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDecrypt.Location = new Point(252, 351);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(106, 23);
            btnDecrypt.TabIndex = 17;
            btnDecrypt.Text = "Descriptografar";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += OnDecryptClick;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 386);
            Controls.Add(btnDecrypt);
            Controls.Add(txtExit);
            Controls.Add(lblExit);
            Controls.Add(txtInput);
            Controls.Add(lblInput);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(btnEncrypt);
            Controls.Add(btnCert);
            Controls.Add(txtCrtPath);
            Controls.Add(lblCrtPath);
            Controls.Add(btnGenCert);
            Name = "MainFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Codificador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGenCert;
        private Label lblCrtPath;
        private TextBox txtCrtPath;
        private Button btnCert;
        private Button btnEncrypt;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblInput;
        private TextBox txtInput;
        private TextBox txtExit;
        private Label lblExit;
        private Button btnDecrypt;
    }
}
