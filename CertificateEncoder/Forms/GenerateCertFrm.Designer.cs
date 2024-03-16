namespace CertificateEncoder.Forms
{
    partial class GenerateCertFrm
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
            txtCertificatePath = new TextBox();
            btnFindRoot = new Button();
            txtCn = new TextBox();
            label2 = new Label();
            btnGenerate = new Button();
            btnOpenPrivate = new Button();
            txtPrivatePath = new TextBox();
            lblCertKeyPath = new Label();
            gbSelectRoot = new GroupBox();
            txtSelectedPrivateKey = new TextBox();
            lblSelectPrivate = new Label();
            btnSelectPrivate = new Button();
            txtSelectedRoot = new TextBox();
            lblSelectRoot = new Label();
            btnSelectRoot = new Button();
            gbCertificateInfo = new GroupBox();
            lblSerialNumber = new Label();
            txtSerialNumber = new TextBox();
            gbType = new GroupBox();
            rbPfx = new RadioButton();
            rbCert = new RadioButton();
            rbRoot = new RadioButton();
            gbSelectRoot.SuspendLayout();
            gbCertificateInfo.SuspendLayout();
            gbType.SuspendLayout();
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
            // txtCertificatePath
            // 
            txtCertificatePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCertificatePath.Location = new Point(5, 37);
            txtCertificatePath.Name = "txtCertificatePath";
            txtCertificatePath.ReadOnly = true;
            txtCertificatePath.Size = new Size(298, 23);
            txtCertificatePath.TabIndex = 8;
            // 
            // btnFindRoot
            // 
            btnFindRoot.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFindRoot.Location = new Point(309, 36);
            btnFindRoot.Name = "btnFindRoot";
            btnFindRoot.Size = new Size(75, 23);
            btnFindRoot.TabIndex = 9;
            btnFindRoot.Text = "Procurar";
            btnFindRoot.UseVisualStyleBackColor = true;
            btnFindRoot.Click += OnCertificateChange;
            // 
            // txtCn
            // 
            txtCn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCn.Location = new Point(5, 127);
            txtCn.Name = "txtCn";
            txtCn.Size = new Size(379, 23);
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
            btnGenerate.Location = new Point(316, 360);
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
            btnOpenPrivate.Location = new Point(309, 82);
            btnOpenPrivate.Name = "btnOpenPrivate";
            btnOpenPrivate.Size = new Size(75, 23);
            btnOpenPrivate.TabIndex = 12;
            btnOpenPrivate.Text = "Procurar";
            btnOpenPrivate.UseVisualStyleBackColor = true;
            btnOpenPrivate.Click += OnOpenPkClick;
            // 
            // txtPrivatePath
            // 
            txtPrivatePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrivatePath.Location = new Point(5, 83);
            txtPrivatePath.Name = "txtPrivatePath";
            txtPrivatePath.ReadOnly = true;
            txtPrivatePath.Size = new Size(298, 23);
            txtPrivatePath.TabIndex = 11;
            // 
            // lblCertKeyPath
            // 
            lblCertKeyPath.AutoSize = true;
            lblCertKeyPath.Location = new Point(5, 65);
            lblCertKeyPath.Name = "lblCertKeyPath";
            lblCertKeyPath.Size = new Size(200, 15);
            lblCertKeyPath.TabIndex = 10;
            lblCertKeyPath.Text = "Caminho para salvar a chave privada";
            // 
            // gbSelectRoot
            // 
            gbSelectRoot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbSelectRoot.Controls.Add(txtSelectedPrivateKey);
            gbSelectRoot.Controls.Add(lblSelectPrivate);
            gbSelectRoot.Controls.Add(btnSelectPrivate);
            gbSelectRoot.Controls.Add(txtSelectedRoot);
            gbSelectRoot.Controls.Add(lblSelectRoot);
            gbSelectRoot.Controls.Add(btnSelectRoot);
            gbSelectRoot.Location = new Point(7, 12);
            gbSelectRoot.Name = "gbSelectRoot";
            gbSelectRoot.Size = new Size(390, 124);
            gbSelectRoot.TabIndex = 16;
            gbSelectRoot.TabStop = false;
            gbSelectRoot.Text = "Selecionar Certificado Root";
            // 
            // txtSelectedPrivateKey
            // 
            txtSelectedPrivateKey.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSelectedPrivateKey.Location = new Point(5, 87);
            txtSelectedPrivateKey.Name = "txtSelectedPrivateKey";
            txtSelectedPrivateKey.ReadOnly = true;
            txtSelectedPrivateKey.Size = new Size(298, 23);
            txtSelectedPrivateKey.TabIndex = 11;
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
            btnSelectPrivate.Location = new Point(309, 86);
            btnSelectPrivate.Name = "btnSelectPrivate";
            btnSelectPrivate.Size = new Size(75, 23);
            btnSelectPrivate.TabIndex = 12;
            btnSelectPrivate.Text = "Procurar";
            btnSelectPrivate.UseVisualStyleBackColor = true;
            btnSelectPrivate.Click += OnSelectPrivateClick;
            // 
            // txtSelectedRoot
            // 
            txtSelectedRoot.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSelectedRoot.Location = new Point(5, 37);
            txtSelectedRoot.Name = "txtSelectedRoot";
            txtSelectedRoot.ReadOnly = true;
            txtSelectedRoot.Size = new Size(298, 23);
            txtSelectedRoot.TabIndex = 8;
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
            btnSelectRoot.Location = new Point(309, 37);
            btnSelectRoot.Name = "btnSelectRoot";
            btnSelectRoot.Size = new Size(75, 23);
            btnSelectRoot.TabIndex = 9;
            btnSelectRoot.Text = "Procurar";
            btnSelectRoot.UseVisualStyleBackColor = true;
            btnSelectRoot.Click += OnSelectRootClick;
            // 
            // gbCertificateInfo
            // 
            gbCertificateInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbCertificateInfo.Controls.Add(lblSerialNumber);
            gbCertificateInfo.Controls.Add(txtSerialNumber);
            gbCertificateInfo.Controls.Add(label1);
            gbCertificateInfo.Controls.Add(txtCertificatePath);
            gbCertificateInfo.Controls.Add(btnFindRoot);
            gbCertificateInfo.Controls.Add(btnOpenPrivate);
            gbCertificateInfo.Controls.Add(label2);
            gbCertificateInfo.Controls.Add(txtPrivatePath);
            gbCertificateInfo.Controls.Add(txtCn);
            gbCertificateInfo.Controls.Add(lblCertKeyPath);
            gbCertificateInfo.Location = new Point(7, 141);
            gbCertificateInfo.Name = "gbCertificateInfo";
            gbCertificateInfo.Size = new Size(390, 204);
            gbCertificateInfo.TabIndex = 17;
            gbCertificateInfo.TabStop = false;
            gbCertificateInfo.Text = "Informações do certificado";
            // 
            // lblSerialNumber
            // 
            lblSerialNumber.AutoSize = true;
            lblSerialNumber.Location = new Point(5, 157);
            lblSerialNumber.Name = "lblSerialNumber";
            lblSerialNumber.Size = new Size(94, 15);
            lblSerialNumber.TabIndex = 15;
            lblSerialNumber.Text = "Número de série";
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSerialNumber.Location = new Point(5, 175);
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.Size = new Size(379, 23);
            txtSerialNumber.TabIndex = 16;
            // 
            // gbType
            // 
            gbType.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbType.Controls.Add(rbPfx);
            gbType.Controls.Add(rbCert);
            gbType.Controls.Add(rbRoot);
            gbType.Location = new Point(7, 351);
            gbType.Name = "gbType";
            gbType.Size = new Size(303, 36);
            gbType.TabIndex = 18;
            gbType.TabStop = false;
            gbType.Text = "Tipo de certificado";
            // 
            // rbPfx
            // 
            rbPfx.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rbPfx.AutoSize = true;
            rbPfx.Location = new Point(186, 13);
            rbPfx.Name = "rbPfx";
            rbPfx.Size = new Size(113, 19);
            rbPfx.TabIndex = 21;
            rbPfx.Text = "Pfx (Com senha)";
            rbPfx.UseVisualStyleBackColor = true;
            rbPfx.CheckedChanged += OnPfxChange;
            // 
            // rbCert
            // 
            rbCert.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rbCert.AutoSize = true;
            rbCert.Checked = true;
            rbCert.Location = new Point(65, 13);
            rbCert.Name = "rbCert";
            rbCert.Size = new Size(115, 19);
            rbCert.TabIndex = 20;
            rbCert.TabStop = true;
            rbCert.Text = "Cert (Sem senha)";
            rbCert.UseVisualStyleBackColor = true;
            // 
            // rbRoot
            // 
            rbRoot.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            rbRoot.AutoSize = true;
            rbRoot.Location = new Point(9, 13);
            rbRoot.Name = "rbRoot";
            rbRoot.Size = new Size(50, 19);
            rbRoot.TabIndex = 19;
            rbRoot.Text = "Root";
            rbRoot.UseVisualStyleBackColor = true;
            rbRoot.CheckedChanged += OnRootChange;
            // 
            // GenerateCertFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 391);
            Controls.Add(gbType);
            Controls.Add(gbCertificateInfo);
            Controls.Add(gbSelectRoot);
            Controls.Add(btnGenerate);
            MaximizeBox = false;
            MinimumSize = new Size(425, 430);
            Name = "GenerateCertFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerar certificado";
            gbSelectRoot.ResumeLayout(false);
            gbSelectRoot.PerformLayout();
            gbCertificateInfo.ResumeLayout(false);
            gbCertificateInfo.PerformLayout();
            gbType.ResumeLayout(false);
            gbType.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtCertificatePath;
        private Button btnFindRoot;
        private TextBox txtCn;
        private Label label2;
        private Button btnGenerate;
        private Button btnOpenPrivate;
        private TextBox txtPrivatePath;
        private Label lblCertKeyPath;
        private GroupBox gbSelectRoot;
        private TextBox txtSelectedPrivateKey;
        private Label lblSelectPrivate;
        private Button btnSelectPrivate;
        private TextBox txtSelectedRoot;
        private Label lblSelectRoot;
        private Button btnSelectRoot;
        private GroupBox gbCertificateInfo;
        private Label lblSerialNumber;
        private TextBox txtSerialNumber;
        private GroupBox gbType;
        private RadioButton rbRoot;
        private RadioButton rbCert;
        private RadioButton rbPfx;
    }
}