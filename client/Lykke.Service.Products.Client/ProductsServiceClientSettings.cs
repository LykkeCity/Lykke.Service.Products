using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.Products.Client 
{
    /// <summary>
    /// Settings for <see cref="IProductsClient"/>.
    /// </summary>
    public class ProductsServiceClientSettings 
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ProductsServiceClientSettings"/> with service url.
        /// </summary>
        public ProductsServiceClientSettings(string serviceUrl)
        {
            ServiceUrl = serviceUrl;
        }

        /// <summary>
        /// The asset disclaimers service url.
        /// </summary>
        [HttpCheck("api/isalive")]
        public string ServiceUrl { get; set; }
    }
}
