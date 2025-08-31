
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Restaurent.Infrastucture.identity;
using RestaurentMnagemntSytem.Data;

namespace Restaurent.Infrastucture
{
    public static class infrastructureRegisteration
    {
        public static IServiceCollection InfrastructureRegister(this IServiceCollection service)
        {
            service.AddIdentity<ApplicationUser, IdentityRole>()
           .AddEntityFrameworkStores<ApplicationDbContext>()
           .AddDefaultTokenProviders()
           .AddDefaultUI();

            return service; 
        }
    }
}
