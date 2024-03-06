namespace AppStoreServerApi.Models
{
    // https://developer.apple.com/documentation/appstoreserverapi/subscriptiongroupidentifieritem
    public class SubscriptionGroupIdentifierItem
    {
        public string SubscriptionGroupIdentifier { get; set; } = null!;
        public List<LastTransactionsItem> LastTransactions { get; set; } = null!;
    }
}
