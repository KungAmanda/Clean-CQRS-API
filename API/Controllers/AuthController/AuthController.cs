using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Application.Dtos;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Infrastructure.Database;
using MediatR;
using Application.Commands.Users.RegisterUser;
using Application.Queries.Users.GetByUsername;

namespace API.Controllers
{
    // Defines the route as "api/[controller]" and sets this class as an API controller.
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly RealDatabase _realDatabase;
        private readonly IConfiguration _configuration;

        public AuthController(IMediator mediator, RealDatabase realDatabase, IConfiguration configuration)
        {
            _mediator = mediator;
            _realDatabase = realDatabase;
            _configuration = configuration;
        }

        // A static user instance for demonstration. In a real application, you'd use a database.
        public static User user = new User();

        // Configuration object to access settings like JWT parameters.


        // Constructor to inject the configuration object.


        // Endpoint for registering a new user.
        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(UserDto request)
        {
            var registerUserCommand = new RegisterUserCommand
            {
                Username = request.Username,
                Password = request.Password
            };

            var registeredUser = await _mediator.Send(registerUserCommand);

            _realDatabase.Users.Add(registeredUser);

            // Returns the registered user. (Note: In real apps, don't return sensitive data.)
            return Ok(registeredUser);
        }


        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserDto request)
        {
            // Använd MediatR för att skicka en GetByUsernameQuery och hämta användaren från databasen
            var query = new GetByUsernameQuery(request.Username);
            var user = await _mediator.Send(query);

            // Kolla om användaren finns och lösenordet är korrekt
            if (user == null || !BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
            {
                return BadRequest("Felaktigt användarnamn eller lösenord");
            }

            // Skapa ett JWT-token för den autentiserade användaren
            var token = CreateToken(user);

            // Returnera det genererade token som svar
            return Ok(token);
        }

        // Helper method to create a JWT token.
        private string CreateToken(User user)
        {
            // just the username is used as a claim.
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username)

            };

            // Fetches the secret key from configuration and creates security key.
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSettings:SecretKey"]));

            // Creates signing credentials using the security key.
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            // Creates the JWT token with the specified issuer, audience, claims, expirationdate, and credentials
            var token = new JwtSecurityToken(
                issuer: _configuration["JwtSettings:Issuer"],
                audience: _configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials
            );

            // Serializes the token to a JWT string and returns it.
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}