using JetBrains.Annotations;
using Lykke.Service.Products.Settings.ServiceSettings;
using Lykke.Service.Products.Settings.SlackNotifications;

namespace Lykke.Service.Products.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings
    {
        public ProductsSettings ProductsService { get; set; }
        public SlackNotificationsSettings SlackNotifications { get; set; }
    }
}
