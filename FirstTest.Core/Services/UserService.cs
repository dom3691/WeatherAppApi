using FirstTest.Core.Dto;
using FirstTest.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest.Core.Services
{
    public class UserService : IUserService
    {
         public List <UserDto> Users { get; set; } = new List<UserDto>();
        public async Task<UserDto> AddUser (UserDto userDto)
        {
            Users.Add(userDto);
            return userDto;

        }
    }
}
