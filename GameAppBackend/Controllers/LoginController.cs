using Microsoft.AspNetCore.Mvc;
using GameAppBackend.Service;

// # TODO : DELETE THIS FILE
namespace GameAppBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
       
        private readonly ILogger<LoginController> _logger;
        private readonly Guid? _id;

        public LoginController(ILogger<LoginController> logger)
        {
            _id = Guid.NewGuid();
            _logger = logger;
        }

        [HttpPost(Name = "PostLogin")]
        public IActionResult Post([FromBody] Models.AuthUserModel user)
        {
            
            if (ModelState.IsValid)
            {
                try
                {
                    AuthUserService authUserService = new AuthUserService(user.UserName, user.Password);
                    if (authUserService.Login())
                    {
                        return Ok("Success");
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                return Unauthorized("");
            }
            else
            {
                return BadRequest("Failure");

            }
        }
    }
}