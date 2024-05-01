using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Domain.Response;
using WinFormsByMetanit.Domain.ViewModels.User;

namespace WinFormsByMetanit.Service.Interfaces
{
    public interface IUserService
    {
        Task<IBaseResponse<User>> AddUser(UserViewModel entity);
        Task<IBaseResponse<IEnumerable<User>>> GetAllUser();
        Task<IBaseResponse<User>> GetUser(string Login, string Password);
        Task<IBaseResponse<bool>> DeleteUser(int id);
    }
}
