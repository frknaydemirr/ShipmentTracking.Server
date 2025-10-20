using FluentValidation;
using MediatR;
using TS.Result;
using static ShipmentTracking.Server.Domain.Cargos.Cargo;

namespace ShipmentTracking.Server.Application.Cargos
{
    public sealed record  class CargoCreateCommand (
        Person Sender,
        Person Reciver,
        Address DeliveryAddress,
        CargoInformation CargoInformation
        ) : IRequest<Result<string>>;


    public sealed class CargoCreateCommandValidator : AbstractValidator<CargoCreateCommand>
    {
        public CargoCreateCommandValidator()
        {
            RuleFor(p => p.Sender.FirstName).NotEmpty().WithMessage("Please entry valid sender name!");
            RuleFor(p => p.Reciver).NotEmpty().WithMessage("Please entry valid reciver name!");
           
        }
}

}
