using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestC.DTO;
using TestC.Interfaces;

namespace TestC.Services
{
    public class UserService : IUserService
    {
      public   List<UserDto> Users { get; set; } new List<UserDto>

        public async Task <UserDto> AddUser (UserDto userDto)
        { 
            Users.Add(userDto);
            return userDto;
        }
    }
}
