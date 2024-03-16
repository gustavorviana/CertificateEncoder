namespace CertificateEncoder.Forms
{
    public partial class GenerateCertFrm : Form
    {
        public const string PfxSave = "Personal Information Exchange (*.pfx)|*.pfx";
        private const string CertSave = "Arquivos de Certificado (*.cer)|*.cer";

        public GenerateCertFrm()
        {
            InitializeComponent();
        }

        private void OnSelectRootClick(object sender, EventArgs e)
        {
            if (ShowOpenDialog(CertSave) is string path)
                this.txtSelectedRoot.Text = path;
        }

        private void OnSelectPrivateClick(object sender, EventArgs e)
        {
            if (ShowOpenDialog("Arquivos de Chave (*.key)|*.key") is string path)
                this.txtSelectedPrivateKey.Text = path;
        }

        private void OnCertificateChange(object sender, EventArgs e)
        {
            if (ShowSaveDialog(this.rbPfx.Checked ? PfxSave : CertSave) is string path)
                this.txtCertificatePath.Text = path;
        }

        private void OnOpenPkClick(object sender, EventArgs e)
        {
            if (ShowSaveDialog("Arquivos de Chave (*.key)|*.key") is string path)
                this.txtPrivatePath.Text = path;
        }

        private void OnGenerateClick(object sender, EventArgs e)
        {
            if (GetErrorMsg() is string errMsg)
            {
                MessageBox.Show(errMsg, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var generator = new CertificateGenerator(this.txtCertificatePath.Text, this.txtPrivatePath.Text);
                if (this.rbRoot.Checked) generator.CreateSelfSigned(this.txtCn.Text);
                else if (this.rbCert.Checked) generator.Create(this.txtSelectedRoot.Text, this.txtSelectedPrivateKey.Text, this.txtCn.Text, null);
                else generator.Create(this.txtSelectedRoot.Text, this.txtSelectedPrivateKey.Text, this.txtCn.Text, null, this.txtPrivatePath.Text);

                MessageBox.Show("Certificado gerado com sucesso.");
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string? GetErrorMsg()
        {
            if (!this.rbRoot.Checked)
            {
                if (string.IsNullOrEmpty(this.txtCertificatePath.Text))
                    return "O certificado root é necessário.";

                if (string.IsNullOrEmpty(this.txtPrivatePath.Text))
                    return "A chave privada é necessária.";
            }

            if (string.IsNullOrEmpty(this.txtCertificatePath.Text))
                return "O caminho para salvar o certificado root é necessário.";

            if (string.IsNullOrEmpty(this.txtPrivatePath.Text))
                return "O caminho para salvar a chave privada é necessário.";

            if (string.IsNullOrEmpty(this.txtCn.Text))
                return "O CN do certificado é necessário.";

            if (this.txtSelectedRoot.Text == this.txtCertificatePath.Text)
                return "Os certificados digitais devem ser diferentes.";

            if (this.txtPrivatePath.Text == this.txtSelectedPrivateKey.Text)
                return "As chaves privadas devem ser diferentes.";

            return null;
        }

        private static string? ShowSaveDialog(string filter)
        {
            using var sfd = new SaveFileDialog();
            sfd.Filter = filter;

            return sfd.ShowDialog() == DialogResult.OK ? sfd.FileName : null;
        }

        private static string? ShowOpenDialog(string filter)
        {
            using var sfd = new OpenFileDialog();
            sfd.Filter = filter;

            return sfd.ShowDialog() == DialogResult.OK ? sfd.FileName : null;
        }

        private void OnRootChange(object sender, EventArgs e)
        {
            this.gbSelectRoot.Enabled = !rbRoot.Checked;
            this.txtSerialNumber.Enabled = !rbRoot.Checked;

            this.txtSelectedRoot.Text = "";
            this.txtSelectedPrivateKey.Text = "";

            this.ResetFields();
        }

        private void OnPfxChange(object sender, EventArgs e)
        {
            this.lblCertKeyPath.Text = this.rbPfx.Checked ? "Senha do certificado" : "Caminho para salvar a chave privada";
            this.btnOpenPrivate.Enabled = !this.rbPfx.Checked;

            this.txtPrivatePath.ReadOnly = !this.rbPfx.Checked;
            this.txtPrivatePath.PasswordChar = this.rbPfx.Checked ? '●' : '\0';
            this.ResetFields();
        }

        private void ResetFields()
        {
            this.txtCertificatePath.Text = "";
            this.txtPrivatePath.Text = "";
        }
    }
}
