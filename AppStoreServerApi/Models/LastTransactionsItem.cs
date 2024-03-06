namespace AppStoreServerApi.Models
{
    // https://developer.apple.com/documentation/appstoreserverapi/lasttransactionsitem
    public class LastTransactionsItem
    {
        public string OriginalTransactionId { get; set; } = null!;
        public SubscriptionStatus Status { get; set; }
        /// <summary>
        /// JWSRenewalInfo https://developer.apple.com/documentation/appstoreserverapi/jwsrenewalinfo
        /// </summary>
        public string SignedRenewalInfo { get; set; } = null!;

        /// <summary>
        /// JWSTransaction https://developer.apple.com/documentation/appstoreserverapi/jwstransaction
        /// </summary>
        public string SignedTransactionInfo { get; set; } = null!;
    }
}
