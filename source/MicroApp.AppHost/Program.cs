var builder = DistributedApplication.CreateBuilder(args);

var redis = builder.AddRedisContainer("cache");

var productapi = builder.AddProject<Projects.Products_API>("productsapi");

var userauthapi = builder.AddProject<Projects.UserAuth_API>("userauthapi");

builder.AddProject<Projects.CloneTGDD_Web>("clonetgddweb")
    .WithReference(productapi)
    .WithReference(userauthapi)
    .WithReference(redis);



builder.Build().Run();
