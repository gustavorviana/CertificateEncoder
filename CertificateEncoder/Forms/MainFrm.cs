namespace CertificateEncoder.Forms
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void OnBrnCertClick(object sender, EventArgs e)
        {
            if (OpenFile(GenerateCertFrm.PfxSave) is string path)
                this.txtCrtPath.Text = path;
        }

        private void OnOpenKeyClick(object sender, EventArgs e)
        {
            if (OpenFile("Arquivos de Chave (*.key)|*.key") is string path)
                this.txtPassword.Text = path;
        }

        private static string? OpenFile(string? extension = null)
        {
            using var ofd = new OpenFileDialog();
            if (!string.IsNullOrEmpty(extension))
                ofd.Filter = extension;

            if (ofd.ShowDialog() == DialogResult.OK)
                return ofd.FileName;

            return null;
        }

        private void OnGenCertClick(object sender, EventArgs e)
        {
            using var genRootFrm = new GenerateCertFrm();
            genRootFrm.ShowDialog();
        }

        private void OnEncryptClick(object sender, EventArgs e)
        {
            if (this.GetErrorMessage() is string message)
            {
                MessageBox.Show(message);
                return;
            }

            try
            {
                using var encrypter = new DataEncripter(this.txtCrtPath.Text, this.txtPassword.Text);
                this.txtExit.Text = encrypter.Encrypt(this.txtInput.Text);
            }
            catch (Exception ex)
            {
                if (ex.Message == "A senha de rede especificada não está correta.")
                    MessageBox.Show(ex.Message);
                else
                    MessageBox.Show("A senha do certificado não é válida ou o dado não foi criptografado com esse certificado.");
            }
        }

        private void OnDecryptClick(object sender, EventArgs e)
        {
            if (this.GetErrorMessage() is string message)
            {
                MessageBox.Show(message);
                return;
            }

            try
            {
                using var encrypter = new DataEncripter(this.txtCrtPath.Text, this.txtPassword.Text);
                this.txtExit.Text = encrypter.Decrypt(this.txtInput.Text);
            }
            catch (Exception ex)
            {
                if (ex.Message == "A senha de rede especificada não está correta.")
                    MessageBox.Show(ex.Message);
                else
                    MessageBox.Show("A senha do certificado não é válida ou o dado não foi criptografado com esse certificado.");
            }
        }

        private string? GetErrorMessage()
        {
            if (string.IsNullOrEmpty(this.txtCrtPath.Text))
                return "Selecione um certificado.";

            if (string.IsNullOrEmpty(this.txtPassword.Text))
                return "Insira uma senha.";

            return null;
        }
    }
}
