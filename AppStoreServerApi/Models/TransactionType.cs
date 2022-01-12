using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi.Models
{
    // https://developer.apple.com/documentation/appstoreserverapi/type
    public class TransactionType
    {
        public const string AutoRenewableSubscription = "Auto-Renewable Subscription";
        public const string NonConsumable = "Non-Consumable";
        public const string Consumable = "Consumable";
        public const string NonRenewingSubscription = "Non-Renewing Subscription";
    }
}
