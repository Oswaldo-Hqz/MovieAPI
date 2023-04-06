﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MovieAPI.Data;
using MovieAPI.DTO;
using MovieAPI.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using MovieAPI.Utils;

namespace MovieAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _Context;
        private readonly IConfiguration _config;

        public AuthController(ApplicationDbContext context, IConfiguration config)
        {
            _Context = context;
            _config = config;
        }

        //public static User user = new User();

        [HttpPost("register"), AllowAnonymous]
        public async Task<ActionResult<User>> Register(RegisterDTO req)
        {
            var email = req.Email.ToLower();

            if (await _Context.Users.AnyAsync(u => u.Email == email))
            {
                return BadRequest("Email already exists");
            }

            var passwordUtils = new PasswordUtils();

            byte[] PasswordHash, PasswordSalt;
            passwordUtils.CreatePasswordHash(req.Password, out PasswordHash, out PasswordSalt);

            User user = new User();

            user.FirstName = req.FirstName;
            user.LastName = req.LastName;
            user.Email = req.Email;
            user.PasswordHash = PasswordHash; 
            user.PasswordSalt = PasswordSalt;
            user.CreatedDate = DateTime.UtcNow;

            var role = await _Context.Roles.FirstOrDefaultAsync(r => r.Name == "user");
            user.Role = role;

            _Context.Users.Add(user);
            await _Context.SaveChangesAsync();

            return CreatedAtAction("GetUser", new { id = user.Id }, user);
        }

        [HttpPost("login"), AllowAnonymous]
        public async Task<ActionResult> Login(LoginDTO req)
        {
            var email = req.Email.ToLower();
            var user = await _Context.Users.SingleOrDefaultAsync(u => u.Email == email);

            if (user == null)
            {
                return Unauthorized("Invalid email or password");
            }

            var passwordUtils = new PasswordUtils();

            if (!passwordUtils.VerifyPasswordHash(req.Password, user.PasswordHash, user.PasswordSalt))
            {
                return Unauthorized("Invalid email or password");
            }

            string Token = CreateToken(user);

            return Ok(new { Token = Token });
        }

        [HttpPost("logout"), Authorize]
        public async Task<ActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok(new { message = "Logout successful" });
        }

        //-------

        private string CreateToken(User user)
        {
            var key = Encoding.UTF8.GetBytes(_config.GetSection("Jwt:Key").Value);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.FirstName + " " + user.LastName),
                    new Claim(ClaimTypes.Role, user.Role.Name),
                    new Claim(ClaimTypes.Email, user.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(_config.GetValue<int>("Jwt:ExpirationTime")),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }

    }
}
