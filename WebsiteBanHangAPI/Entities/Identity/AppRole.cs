using Microsoft.AspNetCore.Identity;

namespace WebsiteBanHangAPI.Entities.Identity
{
    public class AppRole : IdentityRole<int>
    {
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}
