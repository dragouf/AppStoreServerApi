using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
