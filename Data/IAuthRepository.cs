using System.Collections.Generic;
using System.Threading.Tasks;
using Iaf.API.Models;

namespace Iaf.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string user, string password);

         Task<User> GetUser(string user);
         Task<List<User>> SearchUser(string user);
        Task<User> GetUserDetail(string user);
        Task<User> GetUserInfoByUserCode(string UserCode);
         Task<bool> UserExists(string username);

         Task<List<User>> GetAllUser();
         Task<User> Update(User user, string password);
         Task<List<User>> GetAllUserByDepartment(string DepartmentCode);
    }
}

