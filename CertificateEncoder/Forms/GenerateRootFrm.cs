namespace CertificateEncoder.Forms
{
    public partial class GenerateRootFrm : Form
    {
        public GenerateRootFrm()
        {
            InitializeComponent();
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
                using var generator = new CertificateGenerator(this.txtRootPath.Text, this.txtPrivatePath.Text);
                if (this.cbRoot.Checked) generator.CreateSelfSigned(this.txtCn.Text);

                MessageBox.Show("Certificado root gerado com sucesso.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string? GetErrorMsg()
        {
            if (string.IsNullOrEmpty(this.txtRootPath.Text))
                return "O caminho para salvar o certificado root é necessário";

            if (string.IsNullOrEmpty(this.txtPrivatePath.Text))
                return "O caminho para salvar a chave privada é necessário";

            if (string.IsNullOrEmpty(this.txtCn.Text))
                return "O CN do certificado é necessário.";

            return null;
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

        private static string? ShowSaveDialog(string filter)
        {
            using var sfd = new SaveFileDialog();
            sfd.Filter = filter;

            return sfd.ShowDialog() == DialogResult.OK ? sfd.FileName : null;
        }

        private void OnCbRootChange(object sender, EventArgs e)
        {
            this.gbSelectRoot.Enabled = !cbRoot.Checked;
        }
    }
}
