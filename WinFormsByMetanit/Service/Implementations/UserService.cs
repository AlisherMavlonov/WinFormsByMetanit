using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsByMetanit.Dal.Interfaces;
using WinFormsByMetanit.Domain.Entity;
using WinFormsByMetanit.Domain.Helpers;
using WinFormsByMetanit.Domain.Response;
using WinFormsByMetanit.Domain.ViewModels.User;
using WinFormsByMetanit.Service.Interfaces;
using User = WinFormsByMetanit.Domain.Entity.User;

namespace WinFormsByMetanit.Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IBaseResponse<User>> AddUser(UserViewModel entity)
        {
            try
            {
                var user = await _userRepository.GetAll().FirstOrDefaultAsync(x=>x.Login == entity.Login && x.Name == entity.Name);
                if (user != null)
                {
                    return new BaseResponse<User>()
                    {
                        Description = $"В Бд есть пользователь с таким данным",
                        StatusCode = Domain.Enum.StatusCode.UserAlreadyExists
                    };
                }
                user = new User()
                {
                    Name = entity.Name,
                    Lastname = entity.Lastname,
                    PhoneNumber = entity.PhoneNumber,
                    Login = entity.Login,
                    Password = HashPasswordHelpers.HashPassword(entity.Password),
                    PasswordConfig = HashPasswordHelpers.HashPassword(entity.PasswordConfig)
                };
                
                await _userRepository.Create(user);

                return new BaseResponse<User>()
                {
                    Data = user,
                    StatusCode = Domain.Enum.StatusCode.Ok,
                    Description = $"{entity.Name} {entity.Lastname} успешно зарегистрирован!!!"
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<User>
                {
                    Description = ex.Message,
                    StatusCode = Domain.Enum.StatusCode.InternalServerError
                };
            }
        }

        public Task<IBaseResponse<bool>> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IBaseResponse<IEnumerable<User>>> GetAllUser()
        {
            try
            {
                var users = await _userRepository.GetAll().ToListAsync();
                return new BaseResponse<IEnumerable<User>>()
                {
                    Data = users,
                    StatusCode = Domain.Enum.StatusCode.Ok
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<IEnumerable<User>>()
                {
                    Description = ex.Message,
                    StatusCode = Domain.Enum.StatusCode.InternalServerError
                };
            }
        }

        public async Task<IBaseResponse<User>> GetUser(string Login, string Password)
        {
            try
            {

                var user = await _userRepository.GetAll().FirstOrDefaultAsync(x=>x.Login == Login 
                && x.Password == HashPasswordHelpers.HashPassword(Password));
                if (user == null)
                {
                    return new BaseResponse<User>()
                    {
                        Description = $"Неверный логин или пароль!!!",
                        StatusCode = Domain.Enum.StatusCode.UserNotFaund
                    };
                }

                return new BaseResponse<User>()
                {
                    Data = user,
                    Description = $"Пользователь найден!!!",
                    StatusCode = Domain.Enum.StatusCode.Ok
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<User>()
                {
                    Description = ex.Message,
                    StatusCode = Domain.Enum.StatusCode.InternalServerError
                };
            }
        }
    }
}
