using ShipmentTracking.Server.Domain.Users;
using Microsoft.AspNetCore.Identity;

namespace ShipmentTracking.Server.WebAPI;

public static class ExtensionsMiddleware
{
    public static void CreateFirstUser(WebApplication app)
    {
        using (var scoped = app.Services.CreateScope())
        {
            var userManager = scoped.ServiceProvider.GetRequiredService<UserManager<AppUser>>();

            // Eğer admin kullanıcı yoksa oluştur
            if (!userManager.Users.Any(p => p.UserName == "admin"))
            {
                AppUser user = new()
                {
                    Id = Guid.Parse("9aae6c21-1a2e-4d06-a191-6a7ab87f499e"),
                    UserName = "admin",
                    Email = "admin@admin.com",
                    FirstName = "Furkan",
                    LastName = "Aydemir",
                    EmailConfirmed = true,
                    CreateAt = DateTimeOffset.Now,
                };

                // Burada HttpContext’e gerek yok
                user.CreateUserId = user.Id;

                // Kullanıcıyı oluştur
                userManager.CreateAsync(user, "1").Wait();
            }
        }
    }
}
