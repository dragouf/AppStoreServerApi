using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi.Models
{
    // https://developer.apple.com/documentation/appstoreserverapi/subscriptiongroupidentifieritem
    public class SubscriptionGroupIdentifierItem
    {
        public string SubscriptionGroupIdentifier { get; set; } = null!;
        public List<LastTransactionsItem> LastTransactions { get; set; } = null!;
    }
}
