using Candidate.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.Core.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> AddUser(UserDto userDto);
        Task<List<UserDto>> GetUser();
    }
}
