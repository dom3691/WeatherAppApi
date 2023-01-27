using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Testing.Core.DTO;

namespace Testing.Core.Interface
{
    public interface IUserService
    {
        Task<UserDto> AddUser(UserDto userDto);
        Task<List<UserDto>> GetUser();
        Task<List<Transaction>> GetAllTransaction();
    }
    
}
