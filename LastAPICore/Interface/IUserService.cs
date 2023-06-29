using LastAPICore.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastAPICore.Interface
{
    public interface IUserService
    {
        Task<UserDto> AddUser(UserDto userDto);
        Task<List<UserDto>> GetUser();
     //   Task<List<UserDto>> FindByEmail(string email);


    }
}
