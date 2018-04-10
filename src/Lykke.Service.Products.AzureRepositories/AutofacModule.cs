using Autofac;
using Common.Log;
using Lykke.SettingsReader;

namespace Lykke.Service.Products.AzureRepositories
{
    public class AutofacModule : Module
    {
        private readonly IReloadingManager<string> _connectionString;
        private readonly ILog _log;

        public AutofacModule(IReloadingManager<string> connectionString, ILog log)
        {
            _connectionString = connectionString;
            _log = log;
        }

        protected override void Load(ContainerBuilder builder)
        {
        }
    }
}
