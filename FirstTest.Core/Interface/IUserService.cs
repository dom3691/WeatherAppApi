using FirstTest.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstTest.Core.Dto;

namespace FirstTest.Core.Interface
{
    public interface IUserService
    {
        Task<UserDto> AddUser(UserDto userDto);
    }
}
