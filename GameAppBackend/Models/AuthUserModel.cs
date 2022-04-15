namespace GameAppBackend.Models
{
    public class AuthUserModel
    {
        /// Example model for now - using these nice get set var initializers
        public string UserName { get; set; }
        public string Password { get; set; } 
        public string Email { get; set; }   


        // Constructor doin constructor tings
        public AuthUserModel(string userName, string password, string email)
        {
            UserName = userName;
            Password = password;
            Email = email;
        }
    }
}
