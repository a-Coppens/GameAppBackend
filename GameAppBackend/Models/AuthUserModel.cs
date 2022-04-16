using System.ComponentModel.DataAnnotations;

namespace GameAppBackend.Models
{
    public class AuthUserModel
    {
        /// Example model for now - using these nice get set var initializers
        /// Init allows Set on creation only, removing need to constructor
     
        [Required(ErrorMessage = "UserName is required.")]
        [DataType(DataType.Text)]
        public string UserName { get; init; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; init; }

        public string? Salt { get; init; }

    }
}
