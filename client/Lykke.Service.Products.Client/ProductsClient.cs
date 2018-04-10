using System;
using System.Net.Http;
using Microsoft.Extensions.PlatformAbstractions;

namespace Lykke.Service.Products.Client
{
    public class ProductsClient : IProductsClient, IDisposable
    {
        private readonly HttpClient _httpClient;
        private readonly ApiRunner _runner;

        public ProductsClient(ProductsServiceClientSettings settings)
        {
            if (settings == null)
                throw new ArgumentNullException(nameof(settings));

            if (string.IsNullOrEmpty(settings.ServiceUrl))
                throw new ArgumentException("Service URL Required");

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(settings.ServiceUrl),
                DefaultRequestHeaders =
                {
                    {
                        "User-Agent",
                        $"{PlatformServices.Default.Application.ApplicationName}/{PlatformServices.Default.Application.ApplicationVersion}"
                    }
                }
            };
            
            _runner = new ApiRunner();
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}
