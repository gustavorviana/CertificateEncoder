namespace CertificateEncoder.Forms
{
    public partial class GenerateRootFrm : Form
    {
        public GenerateRootFrm()
        {
            InitializeComponent();
        }

        private void OnSelectRootClick(object sender, EventArgs e)
        {
            if (ShowOpenDialog("Arquivos de Certificado (*.cer)|*.cer") is string path)
                this.txtSelectedRoot.Text = path;
        }

        private void OnSelectPrivateClick(object sender, EventArgs e)
        {
            if (ShowOpenDialog("Arquivos de Chave (*.key)|*.key") is string path)
                this.txtSelectedPrivateKey.Text = path;
        }

        private void OnFindRootClick(object sender, EventArgs e)
        {
            if (ShowSaveDialog("Arquivos de Certificado (*.cer)|*.cer") is string path)
                this.txtRootPath.Text = path;
        }

        private void OnOnenPkClick(object sender, EventArgs e)
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
                var generator = new CertificateGenerator(this.txtRootPath.Text, this.txtPrivatePath.Text);
                if (this.cbRoot.Checked) generator.CreateSelfSigned(this.txtCn.Text);
                else generator.Create(this.txtSelectedRoot.Text, this.txtSelectedPrivateKey.Text, this.txtCn.Text, null);

                MessageBox.Show("Certificado root gerado com sucesso.");
                //this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string? GetErrorMsg()
        {
            if (this.cbRoot.Checked)
            {
                if (string.IsNullOrEmpty(this.txtRootPath.Text))
                    return "O certificado root é necessário.";

                if (string.IsNullOrEmpty(this.txtPrivatePath.Text))
                    return "A chave privada é necessária.";
            }

            if (string.IsNullOrEmpty(this.txtRootPath.Text))
                return "O caminho para salvar o certificado root é necessário.";

            if (string.IsNullOrEmpty(this.txtPrivatePath.Text))
                return "O caminho para salvar a chave privada é necessário.";

            if (string.IsNullOrEmpty(this.txtCn.Text))
                return "O CN do certificado é necessário.";

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

        private void OnCbRootChange(object sender, EventArgs e)
        {
            this.gbSelectRoot.Enabled = !cbRoot.Checked;
            this.txtSerialNumber.Enabled = !cbRoot.Checked;
        }
    }
}
