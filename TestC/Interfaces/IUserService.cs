using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestC.DTO;

namespace TestC.Interfaces
{
    public interface IUserService
    {
        List<UserDto> Users { get; set; }

        Task<UserDto> AddUser(UserDto userDto);
        Task<UserDto> AddUser(UserDto userDto);
        Task<UserDto> AddUser(UserDto userDto);
    }
}
