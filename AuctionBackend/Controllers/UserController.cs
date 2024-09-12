using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Register(User user)
    {
        // Dodaj logikę rejestracji użytkownika
        return Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginUser loginUser)
    {
        // Dodaj logikę logowania użytkownika
        return Ok();
    }

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class LoginUser
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
