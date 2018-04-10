using JetBrains.Annotations;
using Lykke.AzureQueueIntegration;

namespace Lykke.Service.Products.Settings.SlackNotifications
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class SlackNotificationsSettings
    {
        public AzureQueueSettings AzureQueue { get; set; }
    }
}
