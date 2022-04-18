using GameAppBackend.Entities;
using GameAppBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GameAppBackend.Repositories
{
    public class UserRepository : Interfaces.IUserRepository
    {
        private readonly UserDataContext _context;

        public UserRepository(UserDataContext context)
        {
            _context = context;
        }

        public bool CreateAuthUserDetails()
        {
            throw new NotImplementedException();
        }

        public UserModel GetAuthUser(string userNameLogin)
        {
            /// Stub Data represents what we'd get from a database call
            /// here for now
            var user = this._context.Users.Select(u => new UserModel
            {
                ID = u.ID,
                UserName = u.UserName,
                Email = u.Email,
                Password = u.Password,
                Salt = u.Salt,
            }).Where(u => u.UserName == userNameLogin);
            UserModel myUser = user.SingleOrDefault();

            return myUser;
        }

        public bool UpdateAuthUserDetails()
        {
            throw new NotImplementedException();
        }
    }
}
