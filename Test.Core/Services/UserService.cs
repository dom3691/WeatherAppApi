using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Dto;
using Test.Core.Interfaces;

namespace Test.Core.Services
{
    public class UserService : IUserService
    {

        public List <UserDto> Users { get; set; } = new List<UserDto>();
        public async Task<UserDto>  AddUser (UserDto userdto)
        {
            Users.Add (userdto);
            return userdto;
        }



    }
}
