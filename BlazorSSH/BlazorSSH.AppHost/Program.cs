var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.BlazorSSH>("blazorssh");

builder.Build().Run();
