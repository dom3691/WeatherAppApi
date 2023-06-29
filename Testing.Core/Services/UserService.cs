using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Testing.Core.DTO;
using Testing.Core.Interface;

namespace Testing.Core.Services
{
    public class UserService : IUserService
    {
        public static List<UserDto> Users { get; set; } = new List<UserDto>();
        public async Task<UserDto> AddUser(UserDto userDto)
        {
            Users.Add(userDto); 
            return userDto;
        }

        public Task<List<Transaction>> GetAllTransaction()
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserDto>> GetUser()
        {
            
            return Users;
        }
    }
}
