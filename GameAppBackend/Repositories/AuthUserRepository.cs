using GameAppBackend.Models;

namespace GameAppBackend.Repositories
{
    public class AuthUserRepository : Interfaces.IAuthUserRepository
    {
        public bool createAuthUserDetails()
        {
            throw new NotImplementedException();
        }

        public AuthUserModel getAuthUser()
        {
            /// Stub Data represents what we'd get from a database call
            /// here for now
            AuthUserModel stubAuthUserData = new AuthUserModel()
            {
                UserName = "xdxdxd",
                /// Sample Hashed password based on password testPassw0rd4 + salt in BCrypt
                Password = "$2a$11$ZHFHLuIC.NL4NkzpKIhSBeKQNduZhzRW.aXf9NpouRCiDb.Ulz0pW",	
                Salt = "$2a$11$ZHFHLuIC.NL4NkzpKIhSBe"
            };

            return stubAuthUserData;
        }

        public bool updateAuthUserDetails()
        {
            throw new NotImplementedException();
        }
    }
}
