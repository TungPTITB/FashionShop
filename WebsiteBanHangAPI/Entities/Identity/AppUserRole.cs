using Microsoft.AspNetCore.Identity;

namespace WebsiteBanHangAPI.Entities.Identity
{
    public class AppUserRole : IdentityUserRole<int>
    {
        public AppUser User { get; set; }
        public AppRole Role { get; set; }
    }
}
