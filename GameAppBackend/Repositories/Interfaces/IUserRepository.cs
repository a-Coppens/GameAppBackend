using GameAppBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameAppBackend.Repositories.Interfaces
{
    public interface IUserRepository
    {
        bool CreateAuthUserDetails();
        bool UpdateAuthUserDetails();
        UserModel GetAuthUser(String userName);

    }
}
