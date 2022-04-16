using GameAppBackend.Models;

namespace GameAppBackend.Repositories.Interfaces
{
    public interface IAuthUserRepository
    {
        bool createAuthUserDetails();
        bool updateAuthUserDetails();
        AuthUserModel getAuthUser();

    }
}
