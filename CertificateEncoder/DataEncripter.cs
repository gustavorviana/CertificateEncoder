using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;

namespace CertificateEncoder
{
    public class DataEncripter(string pfxPath, string password) : IDisposable
    {
        private readonly X509Certificate2 certificate = new(pfxPath, password);
        private bool disposed;

        public string Encrypt(string text)
        {
            using var rsa = certificate.GetRSAPublicKey()!;
            byte[] textoBytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(rsa.Encrypt(textoBytes, RSAEncryptionPadding.Pkcs1));
        }

        public string Decrypt(string text)
        {
            using var rsa = certificate.GetRSAPrivateKey()!;
            byte[] textoCriptografado = Convert.FromBase64String(text);
            return Encoding.UTF8.GetString(rsa.Decrypt(textoCriptografado, RSAEncryptionPadding.Pkcs1));
        }

        #region IDisposable

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
                certificate.Dispose();

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
