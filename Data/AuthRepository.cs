using System;
using System.Threading.Tasks;
using Iaf.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Collections.Generic;
using Iaf.API.Data.Email;
using Microsoft.Extensions.Configuration;
using System.Linq;
using System.Globalization;

namespace Iaf.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        private readonly IEmailSender _emailSender;
        public IConfiguration Configuration { get; }
        public AuthRepository(DataContext context, IEmailSender emailSender, IConfiguration configuration)
        {
            _emailSender = emailSender;
            _context = context;
            Configuration = configuration;
        }

        public async Task<User> Login(string username, string password)
        {
            var user = await _context.Users
                                .FirstOrDefaultAsync(x => (x.Username == username || x.UserCode == username) 
                                                        && x.Status == "ACTIVE");

            if (user == null)
                return null;

            if (!VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                return null;
            }

            return user;
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                        return false;
                }
            }
            return true;
        }

        public async Task<User> Register(User user, string password)
        {
            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            SendEmailRegistration(user, password);            

            return user;
        }

        public async Task<bool> UserExists(string username)
        {
            if (await _context.Users.AnyAsync(x => x.Username == username))
                return true;

            return false;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<User> GetUser(string username)
        {
            var user = await _context.Users
                                .Include(b => b.UserDepartment)
                                .FirstOrDefaultAsync(x => x.Username == username || x.UserCode == username);

            if (user == null)
                return null;

            return user;
        }

        public async Task<List<User>> GetAllUser()
        {
            var users = await _context.Users.Include(x => x.UserDepartment).ToListAsync();

            return users;
        }

        public async Task<User> Update(User user, string password)
        {
            byte[] passwordHash, passwordSalt;
            var curUser = await _context.Users.FirstOrDefaultAsync(x => x.Username == user.Username);

            if(password != "" && password != null){
                CreatePasswordHash(password, out passwordHash, out passwordSalt);

                curUser.PasswordHash = passwordHash;
                curUser.PasswordSalt = passwordSalt;                
            }

            _context.Users.Update(curUser);
            _context.SaveChanges();

            return curUser;
        }
        public void SendEmailRegistration(User User, string password)
        {
            // string ccList = _context.Ticket.FromSqlRaw(sql).SingleOrDefaultAsync().ToString();
            string[] toList = new string[] { User.Email };     
            string[] ccList = new string[] { "muhammad-hafiz.ishak@inari-amertron.com.my" };
            TextInfo myTI = new CultureInfo("en-US",false).TextInfo;
            //string content = "<table border='1'><tr><td>" + MergeEmail(toLista) + "</td></tr></table>";
            string subject = "Inari Quality Tracking System New Account Registration";
            string content = "<div style='font-family:Arial;color:black;font-size:12pt'><span>Hi " + myTI.ToTitleCase(User.Username) + ",</span>" +
                             "<br><br>" +
                             "<span>Your account have been created at Inari Quality Tracking System.</span>" +
                             "<br><br>" +
                             "<span>Below is your account detail:</span>" +
                             "<br>" +
                             "<span>Username: " + User.Username + "</span>" +
                             "<br>" +
                             "<span>Password: " + password + "</span>" +
                             "<br><br>" +                                                         
                             "<span>Please click <a href='" + Configuration.GetSection("CurrentPath:Server").Value + "/'>here</a> to Login.</span>" +
                             "<br><br>" +
                             "<span>Thanks & Regards,</span> " +
                             "<br>" +
                             "<span> IQT Webmaster </span></div> ";

            var message = new Message(toList, ccList, subject, content, null);
            //await _emailSender.SendEmailAsync(message);            
            _emailSender.SendEmail(message);
            //_context.Database.ExecuteSqlRaw("sp_send_iaf_email_notification '" + SerialNo + "'");
        }

        public async Task<List<User>> GetAllUserByDepartment(string DepartmentCode)
        {
            // var userList = await _context.Users
            //                 .Join(_context.UserDepartment, 
            //                         user => user.Id, 
            //                         department => department.User.Id,
            //                         (user, department) => new {
            //                             UserCode = user.UserCode,
            //                             UserName = user.Username,
            //                             Email = user.Email
            //                         })
            //                 //.Where(x => x.DepartmentCode == DepartmentCode)
            //                 .ToListAsync();

            var users = await _context.Users.Include(x => x.UserDepartment)
                                    .Where(x => x.UserDepartment.Any(y => y.DepartmentCode == DepartmentCode))
                                    .ToListAsync();
            
            return users;
        }

        public async Task<User> GetUserDetail(string user)
        {
            var users = await _context.Users
                                .FirstOrDefaultAsync(x => x.Username == user || x.UserCode == user);

            if (users == null)
                return null;

            return users;
        }

        public async Task<List<User>> SearchUser(string user)
        {
            var users = await _context.Users
                                    .Include(a => a.UserDepartment)
                                    .Where(x => x.Username.Contains(user ?? string.Empty) || x.UserCode.Contains(user ?? string.Empty))
                                    .ToListAsync();

            return users;
        }

        public async Task<User> GetUserInfoByUserCode(string UserCode)
        {
            var user = await _context.Users
                                    .Where(x => x.Username == UserCode
                                            || x.UserCode == UserCode)
                                    .FirstOrDefaultAsync();

            return user;
        }
    }
}