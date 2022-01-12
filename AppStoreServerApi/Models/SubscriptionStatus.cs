using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi.Models
{
    // https://developer.apple.com/documentation/appstoreserverapi/status
    public enum SubscriptionStatus
    {
        Active = 1,
        Expired = 2,
        InBillingRetry = 3,
        InBillingGracePeriod = 4,
        Revoked = 5
    }
}
