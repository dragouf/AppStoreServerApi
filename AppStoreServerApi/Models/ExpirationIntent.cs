using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi.Models
{

    // https://developer.apple.com/documentation/appstoreserverapi/expirationintent
    public enum ExpirationIntent
    {
        Canceled = 1,
        BillingError = 2,
        RejectedPriceIncrease = 3,
        ProductUnavailable = 4
    }
}
