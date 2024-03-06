namespace AppStoreServerApi.Models
{
    // https://developer.apple.com/documentation/appstoreservernotifications/notificationtype
    public class NotificationType
    {
        public const string ConsumptionRequest = "CONSUMPTION_REQUEST";
        public const string DidChangeRenewalPref = "DID_CHANGE_RENEWAL_PREF";
        public const string DidChangeRenewalStatus = "DID_CHANGE_RENEWAL_STATUS";
        public const string DidFailToRenew = "DID_FAIL_TO_RENEW";
        public const string DidRenew = "DID_RENEW";
        public const string Expired = "EXPIRED";
        public const string GracePeriodExpired = "GRACE_PERIOD_EXPIRED";
        public const string OfferRedeemed = "OFFER_REDEEMED";
        public const string PriceIncrease = "PRICE_INCREASE";
        public const string Refund = "REFUND";
        public const string RefundDeclined = "REFUND_DECLINED";
        public const string RenewalExtended = "RENEWAL_EXTENDED";
        public const string Revoke = "REVOKE";
        public const string Subscribed = "SUBSCRIBED";
    }
}
