namespace AppStoreServerApi.Models
{
    public class NotificationSubtype
    {
        public const string InitialBuy = "INITIAL_BUY";
        public const string Resubscribe = "RESUBSCRIBE";
        public const string Downgrade = "DOWNGRADE";
        public const string Upgrade = "UPGRADE";
        public const string AutoRenewEnabled = "AUTO_RENEW_ENABLED";
        public const string AutoRenewDisabled = "AUTO_RENEW_DISABLED";
        public const string Voluntary = "VOLUNTARY";
        public const string BillingRetry = "BILLING_RETRY";
        public const string PriceIncrease = "PRICE_INCREASE";
        public const string GracePeriod = "GRACE_PERIOD";
        public const string BillingRecovery = "BILLING_RECOVERY";
        public const string Pending = "PENDING";
        public const string Accepted = "ACCEPTED";
    }
}
