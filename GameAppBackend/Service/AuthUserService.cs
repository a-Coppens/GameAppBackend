using GameAppBackend.Entities;
using GameAppBackend.Models;
using GameAppBackend.Repositories;
using BCryptor = BCrypt.Net.BCrypt;

namespace GameAppBackend.Service
{
    public class AuthUserService : Interfaces.IAuthUserService
    {
        private UserRepository _userRepository;
        private LoginRequest _loginRequest;

        public AuthUserService(LoginRequest loginRequest, UserDataContext context)
        {
            _userRepository = new UserRepository(context);
            _loginRequest = loginRequest;
        }

        public bool Login()
        {
            return DoesPasswordMatchExisting();
        }

        public bool Register()
        {
            throw new NotImplementedException();
        }

        public bool DoesPasswordMatchExisting()
        {
            var existingUser =  _userRepository.GetAuthUser(_loginRequest.Username);

            String hashedPasswordAttempt = BCryptor.HashPassword(_loginRequest.Password, existingUser.Salt);

            if(hashedPasswordAttempt.Equals(existingUser.Password) && _loginRequest.Username.Equals(existingUser.UserName))
            {
                return true;
            }

            return false;


        }
    }
}
