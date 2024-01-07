using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppStoreServerApi.Models
{
    // https://developer.apple.com/documentation/appstoreserverapi/jwstransactiondecodedpayload
    public class JWSTransactionDecodedPayload
    {
        public string? AppAccountToken { get; set; } = null!;
        public string BundleId { get; set; } = null!;
        /// <summary>
        /// UNIX timestamp in ms
        /// </summary>
        public long? ExpiresDate { get; set; } = null!;
        /// <summary>
        /// see: OwnershipType
        /// </summary>
        public string InAppOwnershipType { get; set; } = null!; 
        public bool? IsUpgraded { get; set; } = null!;
        public string? OfferIdentifier { get; set; } = null!;
        public OfferType OfferType { get; set; }
        /// <summary>
        ///  UNIX timestamp in ms
        /// </summary>
        public long OriginalPurchaseDate { get; set; }
        public string OriginalTransactionId { get; set; } = null!;
        public string ProductId { get; set; } = null!;
        /// <summary>
        /// UNIX timestamp in ms
        /// </summary>
        public long PurchaseDate { get; set; } 
        public int Quantity { get; set; }
        /// <summary>
        /// UNIX timestamp in ms
        /// </summary>
        public long? RevocationDate { get; set; } = null!;
        public int? RevocationReason { get; set; } = null!;
        /// <summary>
        /// UNIX timestamp in ms
        /// </summary>
        public long SignedDate { get; set; } 
        public string? SubscriptionGroupIdentifier { get; set; } = null!;
        public string TransactionId { get; set; } = null!;
        /// <summary>
        /// see TransactionType
        /// </summary>
        public string Type { get; set; } = null!; 
        public string WebOrderLineItemId { get; set; } = null!;
    }
}
