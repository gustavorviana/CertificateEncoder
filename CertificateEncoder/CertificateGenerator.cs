using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace CertificateEncoder
{
    public class CertificateGenerator : IDisposable
    {
        private readonly string crtPath;
        private readonly string privateKeyPath;
        private bool disposed;

        private readonly RSA rsa;

        private static readonly DateTimeOffset RootLimitDate = DateTimeOffset.UtcNow.AddYears(10);
        private const int KeySize = 2048;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rootPath">.cer</param>
        /// <param name="privateKeyPath">.key</param>
        public CertificateGenerator(string crtPath, string privateKeySavePath)
        {
            this.crtPath = crtPath;
            this.privateKeyPath = privateKeySavePath;
            rsa = RSA.Create();
            rsa.KeySize = KeySize;
        }

        public void CreateSelfSigned(string cn)
        {
            // Assine o certificado com a própria chave privada
            X509Certificate2 certificate = this.CreateRequest(cn).CreateSelfSigned(DateTimeOffset.UtcNow, RootLimitDate);

            // Exporte a chave privada do certificado
            using RSA privateKey = certificate.GetRSAPrivateKey()!;

            File.WriteAllText(privateKeyPath, ConvertToPEM(privateKey.ExportRSAPrivateKey()));
            File.WriteAllBytes(crtPath, certificate.Export(X509ContentType.Cert));
        }


        private CertificateRequest CreateRequest(string cn)
        {
            // Crie uma solicitação de certificado
            CertificateRequest certificateRequest = new($"CN={cn}", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            // Adicione as informações desejadas ao certificado
            certificateRequest.CertificateExtensions.Add(new X509BasicConstraintsExtension(true, false, 0, true));

            return certificateRequest;
        }

        private static string ConvertToPEM(byte[] privateKeyBytes)
        {
            string base64PrivateKey = Convert.ToBase64String(privateKeyBytes);
            return $"-----BEGIN PRIVATE KEY-----\r\n{base64PrivateKey}\r\n-----END PRIVATE KEY-----";
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
                this.rsa.Dispose();

            disposed = true;
        }

        ~CertificateGenerator()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            ObjectDisposedException.ThrowIf(this.disposed, this);
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
