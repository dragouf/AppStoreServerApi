using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi.Models
{
    // https://developer.apple.com/documentation/appstoreserverapi/offertype
    public enum OfferType
    {
        Introductory = 1,
        Promotional = 2,
        SubscriptionOfferCode = 3
    }
}
