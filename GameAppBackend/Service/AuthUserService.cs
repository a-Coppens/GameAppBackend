using GameAppBackend.Repositories;
using BCryptor = BCrypt.Net.BCrypt;

namespace GameAppBackend.Service
{
    public class AuthUserService : Interfaces.IAuthUserService
    {
        private AuthUserRepository _authUserRepository;
        private readonly String _attemptedLoginUserName;
        private readonly String _attemptedLoginPassword;
        private readonly String _userSalt;

        public AuthUserService(string userName, string password)
        {
            _authUserRepository = new AuthUserRepository();
            _attemptedLoginUserName = userName;
            _attemptedLoginPassword = password;
            _userSalt = _authUserRepository.getAuthUser().Salt;
        }

        public bool Login()
        {
            return doesPasswordMatchExisting();
        }

        public bool Register()
        {
            throw new NotImplementedException();
        }

        public bool doesPasswordMatchExisting()
        {
            String? existingPwd = _authUserRepository.getAuthUser().Password;
            String? existingUserName = _authUserRepository.getAuthUser().UserName;

            String salter = BCryptor.GenerateSalt();
            Console.WriteLine("Salt: " + salter);
            String hashedPasswordAttempt = BCryptor.HashPassword(_attemptedLoginPassword, _authUserRepository.getAuthUser().Salt);

            if(hashedPasswordAttempt.Equals(existingPwd) && _attemptedLoginUserName.Equals(existingUserName))
            {
                return true;
            }

            return false;


        }
    }
}
