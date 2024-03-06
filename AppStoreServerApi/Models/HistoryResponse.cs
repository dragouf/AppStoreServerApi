namespace AppStoreServerApi.Models
{
    // https://developer.apple.com/documentation/appstoreserverapi/historyresponse
    public class HistoryResponse
    {
        public string AppAppleId { get; set; } = null!;
        public string BundleId { get; set; } = null!;
        /// <summary>
        /// see: AppleEnvironment
        /// </summary>
        public string Environment { get; set; } = null!;
        public bool HasMore { get; set; }
        public string Revision { get; set; } = null!;
        // https://developer.apple.com/documentation/appstoreserverapi/jwstransaction
        public List<string> SignedTransactions { get; set; } = null!;
    }
}
