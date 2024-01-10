using Microsoft.EntityFrameworkCore;
using WebsiteBanHangAPI.Data;
using WebsiteBanHangAPI.Helper;
using WebsiteBanHangAPI.Interfaces;
using WebsiteBanHangAPI.Services;

namespace WebsiteBanHangAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
            IConfiguration config)
        {
            services.AddDbContext<StoreContext>(opt =>
            {
                opt.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped<ITokenService, TokenService>();
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.Configure<CloudinarySetting>(config.GetSection("CloudinarySettings"));
            services.AddScoped<IPhotoService, PhotoService>();
            //services.AddScoped<LogUserActivity>();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddSignalR();
            //services.AddSingleton<PresenceTracker>();

            return services;
        }
    }
}
