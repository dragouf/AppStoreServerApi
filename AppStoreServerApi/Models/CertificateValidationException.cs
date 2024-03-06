namespace AppStoreServerApi.Models
{
    public class CertificateValidationException: Exception
    {
        public List<string> Certificates { get; set; }

        public CertificateValidationException(List<string> certificates): base("Certificate validation failed")
        {
            this.Certificates = certificates;
        }
    }
}
