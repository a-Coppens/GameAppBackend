using System.ComponentModel.DataAnnotations;

namespace GameAppBackend.Models
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "UserName is required.")]
        [DataType(DataType.Text)]
        private string _username;

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        private string _password;

        public LoginRequest(String username, String password)
        {
            _username = username;
            _password = password;
        }

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
