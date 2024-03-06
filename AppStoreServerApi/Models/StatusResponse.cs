namespace AppStoreServerApi.Models
{
    // https://developer.apple.com/documentation/appstoreserverapi/statusresponse
    public class StatusResponse
    {
        public List<SubscriptionGroupIdentifierItem> Data { get; set; } = null!;
        /// <summary>
        /// see: AppleEnvironment
        /// </summary>
        public string Environment { get; set; } = null!; 
        public string AppAppleId { get; set; } = null!;
        public string BundleId { get; set; } = null!;
    }
}
