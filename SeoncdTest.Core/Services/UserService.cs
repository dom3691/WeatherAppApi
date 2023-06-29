using SeoncdTest.Core.Dto;
using SeoncdTest.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeoncdTest.Core.Services
{
    public class UserService : IUserService
    {

        public static List <UserDto> Users { get; set; } = new List <UserDto> ();
        public async Task<UserDto> AddUser(UserDto userDto)
        {
            Users.Add(userDto);
            return userDto;
        }

        public async Task<List<UserDto>> GetUser()
        {
            return Users;
        }

        public async Task<UserDto> FindByEmail (string email)
        {
            return  Users.Where (x => x.Email.ToLower().Trim() == email.ToLower().Trim()).FirstOrDefault();
        }


        public async Task<List<EmailDto>> GetUserEmail()
        {
          return Users.Select(x => new EmailDto()
          {
              Email = x.Email,
          }).ToList();   
         //   return EmailDto;
        }
    }
}
