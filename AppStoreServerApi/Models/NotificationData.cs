using System;

namespace AppStoreServerApi.Models
{
    public class NotificationData
    {
        public string AppAppleId { get; set; } = null!;
        public string BundleId { get; set; } = null!;
        public int BundleVersion { get; set; }
        /// <summary>
        /// see: AppleEnvironment
        /// </summary>
        public string Environment { get; set; } = null!;
        public string SignedRenewalInfo { get; set; } = null!;
        public string SignedTransactionInfo { get; set; } = null!;
    }
}
