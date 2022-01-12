using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi.Models
{
    // https://developer.apple.com/documentation/appstoreserverapi/jwsdecodedheader
    public class JWSDecodedHeader
    {
        public string Alg { get; set; } = null!;
        public string Kid { get; set; } = null!;
        public List<string> X5c { get; set; } = null!;
    }
}
