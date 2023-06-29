using Candidate.Core.Dto;
using Candidate.Core.Interfaces;
using Candidate.Data;
using Microsoft.AspNetCore.Identity;

namespace Candidate.Core.Services
{
    public class UserService : IUserService
    {
        private UserManager<AppUser> _userManager;
        private SignInManager<AppUser> _signInManager;

        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public static List<UserDto> Users { get; set; } = new List<UserDto>();
        public async Task<UserDto> AddUser(UserDto userDto)
        {
            var user = new AppUser()
            {
                UserName = userDto.Email,
                Email = userDto.Email,
               // EmailID = userDto.EmailID,
            };
            var result = await _userManager.CreateAsync(user, "P@ssw0rd");
            if(result.Succeeded)
            {
                return userDto;
            }
            return null;
        }

        public async Task<List<UserDto>> GetUser ()
        {
            return Users;
        }
    }
}
