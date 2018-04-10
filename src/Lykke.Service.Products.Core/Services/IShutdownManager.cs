using System.Threading.Tasks;

namespace Lykke.Service.Products.Core.Services
{
    public interface IShutdownManager
    {
        Task StopAsync();
    }
}
