using ShipmentTracking.Server.Domain.Users;

namespace ShipmentTracking.Server.Application.Services;
public interface IJwtProvider
{
    public Task<string> CreateTokenAsync(AppUser user, string password, CancellationToken cancellationToken = default);
}
