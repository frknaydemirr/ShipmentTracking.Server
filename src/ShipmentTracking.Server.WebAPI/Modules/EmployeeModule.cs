﻿

using MediatR;
using TS.Result;

namespace ShipmentTracking.Server.WebAPI.Modules;

public static class EmployeeModule
{
    public static void RegisterEmployeeRoutes(this IEndpointRouteBuilder app)
    {
        RouteGroupBuilder group = app.MapGroup("/employees").WithTags("Employees").RequireAuthorization();

        //group.MapPost(string.Empty,
        //    async (ISender sender, EmployeeCreateCommand request, CancellationToken cancellatioNToken) =>
        //    {
        //        var response = await sender.Send(request, cancellatioNToken);
        //        return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        //    })
        //    .Produces<Result<string>>();

        //group.MapGet(string.Empty,
        //    async (ISender sender, Guid id, CancellationToken cancellatioNToken) =>
        //    {
        //        var response = await sender.Send(new EmployeeGetQuery(id), cancellatioNToken);
        //        return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
        //    })
            //.Produces<Result<Employee>>();
    }
}
