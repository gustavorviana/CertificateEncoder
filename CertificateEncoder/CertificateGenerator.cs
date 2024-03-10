using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Text;

namespace CertificateEncoder
{
    public class CertificateGenerator
    {
        private readonly string crtPath;
        private readonly string privateKeyPath;

        private readonly DateTimeOffset RootLimitDate = DateTimeOffset.UtcNow.AddYears(10);
        private readonly DateTimeOffset CrtLimitDate = DateTimeOffset.UtcNow.AddYears(1);
        private const int KeySize = 2048;

        public CertificateGenerator(string crtPath, string privateKeySavePath)
        {
            this.crtPath = crtPath;
            this.privateKeyPath = privateKeySavePath;
        }

        public void CreateSelfSigned(string cn)
        {
            using var rsa = RSA.Create(KeySize);
            this.Save(rsa, CreateSelfSignedRequest(rsa, true, cn).CreateSelfSigned(DateTimeOffset.UtcNow, RootLimitDate), X509ContentType.Cert);
        }

        public void Create(string rootPath, string privateKeyPath, string cn, string? serialNumber)
        {
            byte[] serialBytes = string.IsNullOrEmpty(serialNumber) ? [0] : Encoding.UTF8.GetBytes(serialNumber);
            this.Create(new X509Certificate2(rootPath).CopyWithPrivateKey(ReadPEM(privateKeyPath)), cn, serialBytes);
        }

        public void Create(X509Certificate2 rootCertificate, string cn, byte[] serialNumber)
        {
            using var rsa = RSA.Create(KeySize);
            this.Save(rsa, CreateClientRequest(rsa, cn).Create(rootCertificate, DateTimeOffset.UtcNow.AddDays(-1), CrtLimitDate, serialNumber), X509ContentType.Cert);
        }

        private void Save(RSA rsa, X509Certificate2 certificate, X509ContentType contentType)
        {
            File.WriteAllText(privateKeyPath, rsa.ExportRSAPrivateKeyPem());
            File.WriteAllBytes(crtPath, certificate.Export(contentType));
        }

        private static CertificateRequest CreateSelfSignedRequest(RSA rsa, bool certificateAuthority, string cn)
        {
            // Crie uma solicitação de certificado
            CertificateRequest certificateRequest = new($"CN={cn}", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            // Adicione as informações desejadas ao certificado
            certificateRequest.CertificateExtensions.Add(new X509BasicConstraintsExtension(certificateAuthority, false, 0, certificateAuthority));

            return certificateRequest;
        }

        private static CertificateRequest CreateClientRequest(RSA rsa, string cn)
        {
            var request = new CertificateRequest($"CN={cn}", rsa, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

            // Configuração do certificado do cliente
            request.CertificateExtensions.Add(new X509BasicConstraintsExtension(false, false, 0, false));
            request.CertificateExtensions.Add(
                new X509KeyUsageExtension(X509KeyUsageFlags.DigitalSignature | X509KeyUsageFlags.NonRepudiation | X509KeyUsageFlags.KeyEncipherment | X509KeyUsageFlags.DataEncipherment, false)
            );
            request.CertificateExtensions.Add(new X509EnhancedKeyUsageExtension([new Oid("1.3.6.1.5.5.7.3.2"), new Oid("1.3.6.1.5.5.7.3.1")], false));
            request.CertificateExtensions.Add(new X509SubjectKeyIdentifierExtension(request.PublicKey, false));

            return request;
        }

        private static RSA ReadPEM(string filePath)
        {
            RSA rsa = RSA.Create();
            rsa.ImportFromPem(File.ReadAllText(filePath));
            return rsa;
        }
    }
}
