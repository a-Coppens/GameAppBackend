namespace GameAppBackend.Models
{
    public class UserModel
    {
        /// Example model for now - using these nice get set var initializers
        /// Init allows Set on creation only, removing need to constructor
        public int? ID { get; init; }
        public string? UserName { get; init; }
        public string? Email { get; init; }
        public string? Password { get; init; }
        public string? Salt { get; init; }

    }
}
