namespace CertificateEncoder.Forms
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void OnOpenRootClick(object sender, EventArgs e)
        {
            if (OpenFile("") is not string path)
                return;
        }

        private string? OpenFile(string? extension = null)
        {
            using var ofd = new OpenFileDialog();
            if (!string.IsNullOrEmpty(extension))
                ofd.Filter = extension;

            if (ofd.ShowDialog() == DialogResult.OK)
                return ofd.FileName;

            return null;
        }

        private void OnGenRootClick(object sender, EventArgs e)
        {
            using var genRootFrm = new GenerateRootFrm();
            genRootFrm.ShowDialog();
        }
    }
}
