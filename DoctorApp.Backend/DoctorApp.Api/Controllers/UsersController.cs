using DoctorApp.Data.Context;
using DoctorApp.Data.Interfaces;
using DoctorApp.Models.DTOs;
using DoctorApp.Models.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace DoctorApp.Api.Controllers
{

    public class UsersController : BaseApiController
    {
        private readonly DoctorContext _context;
        private readonly ITokenService _tokenService;

        public UsersController(DoctorContext context, ITokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }


        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Users>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return Ok(users);
        }
        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Users>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            return Ok(user);
        }

        [HttpPost("Register")]
        public async Task<ActionResult<UserDto>> Register([FromBody] UserRegisterDTO user)
        {
            if (await userExits(user.Username)) return BadRequest("El Usuario ya esta en uso");
            using var hmac = new HMACSHA512();
            var usuario = new Users
            {
                Username = user.Username.ToLower(),
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password)),
                PasswordSalt = hmac.Key
            };
            _context.Users.Add(usuario);
            await _context.SaveChangesAsync();
            return Created($"/api/Users/{usuario.Id}", new UserDto
            {
                Username = user.Username.ToLower(),
                Token = _tokenService.GetToken(usuario)
            });
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(UserLoginDTO user)
        {
            var usuario = await _context.Users.SingleOrDefaultAsync(x => x.Username == user.Username.ToLower());
            if (usuario == null) return NotFound("El Usuario no existe");
            using var hmac = new HMACSHA512(usuario.PasswordSalt);
            var computeHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
            for (int i = 0; i < computeHash.Length; i++)
            {
                if (computeHash[i] != usuario.PasswordHash[i]) return Unauthorized("Password Invalid");
            }

            return Ok(new UserDto
            {
                Username = user.Username.ToLower(),
                Token = _tokenService.GetToken(usuario)

            });

        }








        private async Task<bool> userExits(string username)
        {
            return await _context.Users.AnyAsync(x => x.Username == username.ToLower());
        }
    }
}

