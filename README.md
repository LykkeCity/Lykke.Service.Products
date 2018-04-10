# Lykke.Service.Products

Legal entity products

Client: [Nuget](https://www.nuget.org/packages/Lykke.Service.Products.Client/)

# Client usage

Register client services in container:

```cs
ContainerBuilder builder;
...
var settings = new ProductsServiceClientSettings("http://<service>:[port]/");
builder.RegisterInstance(new ProductsClient(settings))
    .As<IProductsClient>()
    .SingleInstance();
```

Now you can use:

* IProductsClient - HTTP client for service API