using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi.Models
{
    // https://developer.apple.com/documentation/appstoreserverapi/inappownershiptype
    public class OwnershipType
    {
        public const string Purchased = "PURCHASED";
        public const string FamilyShared = "FAMILY_SHARED";
    }
}
