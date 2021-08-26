using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Iaf.API.Data;
using Iaf.API.DTO;
using Iaf.API.Models;
using Iaf.API.Models.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace Iaf.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repository;
        private readonly IConfiguration _config;
        public AuthController(IAuthRepository repository, IConfiguration config)
        {
            _config = config;
            _repository = repository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] UserForRegisterDto userForRegisterDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

            if (await _repository.UserExists(userForRegisterDto.Username))
                return BadRequest("Username already exist");

            var userToCreate = new User
            {
                Username = userForRegisterDto.Username,
                UserCode = userForRegisterDto.UserCode,
                EmployeeName = userForRegisterDto.EmployeeName,
                Email = userForRegisterDto.Email,
                UserGroup = userForRegisterDto.UserGroup,
                Status = "ACTIVE",
                JobTitle = userForRegisterDto.JobTitle
            };

            var createdUser = await _repository.Register(userToCreate, userForRegisterDto.Password);

            //return CreatedAtRoute
            return StatusCode(201);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var userFromRepo = await _repository.Login(userForLoginDto.Username, userForLoginDto.Password);

            if (userFromRepo == null)
                return Unauthorized();

            var claims = new[] {
                new Claim (ClaimTypes.NameIdentifier, userFromRepo.Id.ToString ()),
                new Claim (ClaimTypes.Name, userFromRepo.Username)//,
                //new Claim (ClaimTypes.Name, userFromRepo.UserCode)
                
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new
            {
                token = tokenHandler.WriteToken(token),
            });
        }

        [HttpGet("getUser")]
        public async Task<IActionResult> GetUser(string username)
        {
            var userFromRepo = await _repository.GetUser(username);

            if (userFromRepo == null)
                return Unauthorized();
            var detail = new object();

            return Ok(new
            {
                //detail = userFromRepo.Username
                userFromRepo
            });
        }

        [HttpGet("getUserByUser/{username}")]
        public async Task<IActionResult> getUserByUser(string username)
        {
            var userFromRepo = await _repository.GetUser(username);

            // if (userFromRepo == null){
            //     return userFromRepo;
            // }

            return Ok(userFromRepo);
        }

        [HttpGet("searchUser/{username}")]
        public async Task<IActionResult> searchUser(string username)
        {
            var userFromRepo = await _repository.SearchUser(username);

            // if (userFromRepo == null){
            //     return userFromRepo;
            // }

            return Ok(userFromRepo);
        }        

        [HttpGet("getAllUser")]
        public async Task<IActionResult> GetAllUser()
        {
            var users = await _repository.GetAllUser();

            return Ok(users);
        }
        [HttpPost("update")]
        public async Task<IActionResult> Update(UserUpdateDto userDTO)
        {
            var userFromRepo = await _repository.GetUser(userDTO.Username);

            if (userFromRepo != null)
            {
                userFromRepo.Email = userDTO.Email;
                userFromRepo.UserGroup = userDTO.UserGroup;
                userFromRepo.Status = userDTO.Status;

                await _repository.Update(userFromRepo, userDTO.Password);
            }

            if (userFromRepo == null)
                return Unauthorized();

            return Ok();
        }

        [HttpGet("GetAllUserByDepartment/{DepartmentCode}")]
        public async Task<IActionResult> GetAllUserByDepartment(string DepartmentCode)
        {
            var users = await _repository.GetAllUserByDepartment(DepartmentCode);

            return Ok(users);
        }
        [HttpGet("GetUserJobTitleByUserCode")]
        public async Task<IActionResult> GetUserJobTitleByUserCode(string UserCode)
        {
            var users = await _repository.GetUserInfoByUserCode(UserCode);


            return Ok(new {Status = 200, Message = "Success", UserInfo = new {JobTitle = users.JobTitle} });
        }        
    }
}