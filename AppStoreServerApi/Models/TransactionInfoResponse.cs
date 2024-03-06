namespace AppStoreServerApi.Models
{
    // https://developer.apple.com/documentation/appstoreserverapi/transactioninforesponse
    public class TransactionInfoResponse
    {
        /// <summary>
        /// JWSTransaction
        /// </summary>
        public string SignedTransactionInfo { get; set; } = null!;
    }
}