using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserTest.Dto;
using UserTest.Interface;

namespace UserTest.Services
{
    public class UserService : IUserService
    {

        public List<UserDto> Users { get; set; } = new List<UserDto>(); 
        public async Task<UserDto> AddUser (UserDto userDto)

        {
            Users.Add(userDto); 
            return userDto;
        }


        public async Task<List<UserDto>> GetUser()

        {
            
            return Users;
        }

        public async Task<UserDto> FindByEmail(string email)
        {
            return Users.Where(x => x.Email.ToLower().Trim() == email.ToLower().Trim()).FirstOrDefault();
        }
    }
}
