using Microsoft.AspNetCore.Mvc;
using GameAppBackend.Service;
using GameAppBackend.Models;
using GameAppBackend.Entities;

// # TODO : DELETE THIS FILE
namespace GameAppBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
       
        private readonly ILogger<LoginController> _logger;
        private readonly UserDataContext _context;

        public LoginController(ILogger<LoginController> logger, UserDataContext context)
        {
            _logger = logger;
            _context = context;

        }

        [HttpPost(Name = "PostLogin")]
        public IActionResult Post([FromBody]LoginRequest req)
        {
            
            if (ModelState.IsValid)
            {
                try
                {
                    AuthUserService authUserService = new AuthUserService(req, _context);
                    if (authUserService.Login())
                    {
                        return Ok("Success");
                    }
                }
                catch (Exception e)
                {
                    _logger.LogError(e.Message, this);
                    throw ;
                }
                return Unauthorized("Failure");
            }
            else
            {
                return BadRequest("Failure");

            }
        }
    }
}