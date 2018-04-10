using JetBrains.Annotations;
using Lykke.Service.Products.Settings.ServiceSettings.Db;

namespace Lykke.Service.Products.Settings.ServiceSettings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class ProductsSettings
    {
        public DbSettings Db { get; set; }
    }
}
