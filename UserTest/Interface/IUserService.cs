using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTest.Dto;

namespace UserTest.Interface
{
    public interface IUserService
    {
        Task<UserDto> AddUser (UserDto userDto);
        Task<List<UserDto>> GetUser();
        Task<UserDto> FindByEmail(string email);
    }
}
