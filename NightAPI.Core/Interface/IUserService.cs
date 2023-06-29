using NightAPI.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightAPI.Core.Interface
{
    public interface IUserService
    {
        Task<UserDto> AddUser(UserDto userDto);
        Task<List<UserDto>> GetUser(UserDto userDto);
    }
}
