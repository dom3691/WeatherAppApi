using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Core.Dto;

namespace Test.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> AddUser(UserDto userdto);
    }
}
