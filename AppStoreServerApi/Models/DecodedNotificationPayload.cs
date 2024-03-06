namespace AppStoreServerApi.Models
{
    public class DecodedNotificationPayload
    {
        /// <summary>
        /// see: NotificationType
        /// </summary>
        public string NotificationType { get; set; } = null!;
        /// <summary>
        /// see: NotificationSubtype
        /// </summary>
        public string? Subtype { get; set; }
        public string NotificationUUID { get; set; } = null!;
        /// <summary>
        /// Apple incorrectly calls this `notificationVersion` in their documentation.
        /// </summary>
        public string Version { get; set; } = null!; 
        public NotificationData Data { get; set; } = null!;
    }
}
