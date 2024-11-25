var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Hako_ApiService>("apiservice");

builder.AddProject<Projects.Hako_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
