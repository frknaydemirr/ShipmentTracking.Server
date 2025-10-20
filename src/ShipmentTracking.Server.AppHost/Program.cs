var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ShipmentTracking_Server_WebAPI>("shipmenttracking-server-webapi");

builder.Build().Run();
