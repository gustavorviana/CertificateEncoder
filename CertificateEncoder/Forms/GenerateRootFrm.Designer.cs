namespace CertificateEncoder.Forms
{
    partial class GenerateRootFrm
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
            label1 = new Label();
            txtRootPath = new TextBox();
            btnFindRoot = new Button();
            txtCn = new TextBox();
            label2 = new Label();
            btnGenerate = new Button();
            btnOpenPrivate = new Button();
            txtPrivatePath = new TextBox();
            label3 = new Label();
            cbRoot = new CheckBox();
            gbSelectRoot = new GroupBox();
            txtPkPath = new TextBox();
            lblSelectPrivate = new Label();
            btnSelectPrivate = new Button();
            textBox1 = new TextBox();
            lblSelectRoot = new Label();
            btnSelectRoot = new Button();
            gbCertificateInfo = new GroupBox();
            gbSelectRoot.SuspendLayout();
            gbCertificateInfo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 19);
            label1.Name = "label1";
            label1.Size = new Size(184, 15);
            label1.TabIndex = 7;
            label1.Text = "Caminho para salvar o certificado";
            // 
            // txtRootPath
            // 
            txtRootPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRootPath.Enabled = false;
            txtRootPath.Location = new Point(5, 37);
            txtRootPath.Name = "txtRootPath";
            txtRootPath.Size = new Size(275, 23);
            txtRootPath.TabIndex = 8;
            // 
            // btnFindRoot
            // 
            btnFindRoot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFindRoot.Location = new Point(284, 36);
            btnFindRoot.Name = "btnFindRoot";
            btnFindRoot.Size = new Size(75, 23);
            btnFindRoot.TabIndex = 9;
            btnFindRoot.Text = "Procurar";
            btnFindRoot.UseVisualStyleBackColor = true;
            btnFindRoot.Click += OnFindRootClick;
            // 
            // txtCn
            // 
            txtCn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCn.Location = new Point(5, 127);
            txtCn.Name = "txtCn";
            txtCn.Size = new Size(354, 23);
            txtCn.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 109);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 13;
            label2.Text = "Cn do certificado";
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGenerate.Location = new Point(297, 355);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(75, 23);
            btnGenerate.TabIndex = 15;
            btnGenerate.Text = "Gerar";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += OnGenerateClick;
            // 
            // btnOpenPrivate
            // 
            btnOpenPrivate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenPrivate.Location = new Point(284, 82);
            btnOpenPrivate.Name = "btnOpenPrivate";
            btnOpenPrivate.Size = new Size(75, 23);
            btnOpenPrivate.TabIndex = 12;
            btnOpenPrivate.Text = "Procurar";
            btnOpenPrivate.UseVisualStyleBackColor = true;
            btnOpenPrivate.Click += OnOnenPkClick;
            // 
            // txtPrivatePath
            // 
            txtPrivatePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrivatePath.Enabled = false;
            txtPrivatePath.Location = new Point(5, 83);
            txtPrivatePath.Name = "txtPrivatePath";
            txtPrivatePath.Size = new Size(275, 23);
            txtPrivatePath.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 65);
            label3.Name = "label3";
            label3.Size = new Size(200, 15);
            label3.TabIndex = 10;
            label3.Text = "Caminho para salvar a chave privada";
            // 
            // cbRoot
            // 
            cbRoot.AutoSize = true;
            cbRoot.Location = new Point(12, 12);
            cbRoot.Name = "cbRoot";
            cbRoot.Size = new Size(79, 19);
            cbRoot.TabIndex = 0;
            cbRoot.Text = "Gerar root";
            cbRoot.UseVisualStyleBackColor = true;
            cbRoot.CheckedChanged += OnCbRootChange;
            // 
            // gbSelectRoot
            // 
            gbSelectRoot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbSelectRoot.Controls.Add(txtPkPath);
            gbSelectRoot.Controls.Add(lblSelectPrivate);
            gbSelectRoot.Controls.Add(btnSelectPrivate);
            gbSelectRoot.Controls.Add(textBox1);
            gbSelectRoot.Controls.Add(lblSelectRoot);
            gbSelectRoot.Controls.Add(btnSelectRoot);
            gbSelectRoot.Location = new Point(7, 37);
            gbSelectRoot.Name = "gbSelectRoot";
            gbSelectRoot.Size = new Size(365, 124);
            gbSelectRoot.TabIndex = 16;
            gbSelectRoot.TabStop = false;
            gbSelectRoot.Text = "Selecionar Sertificado Root";
            // 
            // txtPkPath
            // 
            txtPkPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPkPath.Enabled = false;
            txtPkPath.Location = new Point(5, 87);
            txtPkPath.Name = "txtPkPath";
            txtPkPath.Size = new Size(275, 23);
            txtPkPath.TabIndex = 11;
            // 
            // lblSelectPrivate
            // 
            lblSelectPrivate.AutoSize = true;
            lblSelectPrivate.Location = new Point(5, 69);
            lblSelectPrivate.Name = "lblSelectPrivate";
            lblSelectPrivate.Size = new Size(82, 15);
            lblSelectPrivate.TabIndex = 10;
            lblSelectPrivate.Text = "Chave privada";
            // 
            // btnSelectPrivate
            // 
            btnSelectPrivate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectPrivate.Location = new Point(284, 86);
            btnSelectPrivate.Name = "btnSelectPrivate";
            btnSelectPrivate.Size = new Size(75, 23);
            btnSelectPrivate.TabIndex = 12;
            btnSelectPrivate.Text = "Procurar";
            btnSelectPrivate.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Enabled = false;
            textBox1.Location = new Point(5, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 23);
            textBox1.TabIndex = 8;
            // 
            // lblSelectRoot
            // 
            lblSelectRoot.AutoSize = true;
            lblSelectRoot.Location = new Point(5, 19);
            lblSelectRoot.Name = "lblSelectRoot";
            lblSelectRoot.Size = new Size(90, 15);
            lblSelectRoot.TabIndex = 7;
            lblSelectRoot.Text = "Certificado root";
            // 
            // btnSelectRoot
            // 
            btnSelectRoot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectRoot.Location = new Point(284, 37);
            btnSelectRoot.Name = "btnSelectRoot";
            btnSelectRoot.Size = new Size(75, 23);
            btnSelectRoot.TabIndex = 9;
            btnSelectRoot.Text = "Procurar";
            btnSelectRoot.UseVisualStyleBackColor = true;
            // 
            // gbCertificateInfo
            // 
            gbCertificateInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbCertificateInfo.Controls.Add(label1);
            gbCertificateInfo.Controls.Add(txtRootPath);
            gbCertificateInfo.Controls.Add(btnFindRoot);
            gbCertificateInfo.Controls.Add(btnOpenPrivate);
            gbCertificateInfo.Controls.Add(label2);
            gbCertificateInfo.Controls.Add(txtPrivatePath);
            gbCertificateInfo.Controls.Add(txtCn);
            gbCertificateInfo.Controls.Add(label3);
            gbCertificateInfo.Location = new Point(7, 186);
            gbCertificateInfo.Name = "gbCertificateInfo";
            gbCertificateInfo.Size = new Size(365, 160);
            gbCertificateInfo.TabIndex = 17;
            gbCertificateInfo.TabStop = false;
            gbCertificateInfo.Text = "Informações do certificado";
            // 
            // GenerateRootFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 390);
            Controls.Add(gbCertificateInfo);
            Controls.Add(gbSelectRoot);
            Controls.Add(cbRoot);
            Controls.Add(btnGenerate);
            MaximizeBox = false;
            Name = "GenerateRootFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exportar";
            gbSelectRoot.ResumeLayout(false);
            gbSelectRoot.PerformLayout();
            gbCertificateInfo.ResumeLayout(false);
            gbCertificateInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRootPath;
        private Button btnFindRoot;
        private TextBox txtCn;
        private Label label2;
        private Button btnGenerate;
        private Button btnOpenPrivate;
        private TextBox txtPrivatePath;
        private Label label3;
        private CheckBox cbRoot;
        private GroupBox gbSelectRoot;
        private TextBox txtPkPath;
        private Label lblSelectPrivate;
        private Button btnSelectPrivate;
        private TextBox textBox1;
        private Label lblSelectRoot;
        private Button btnSelectRoot;
        private GroupBox gbCertificateInfo;
    }
}