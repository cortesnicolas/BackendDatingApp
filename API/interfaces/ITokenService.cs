using API.Entities;

namespace API.interfaces
{
    public interface ITokenService
    {
        string CreateTocken(AppUser user);
    }
}