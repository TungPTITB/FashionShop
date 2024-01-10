using WebsiteBanHangAPI.Entities.Identity;

namespace WebsiteBanHangAPI.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
    }
}
