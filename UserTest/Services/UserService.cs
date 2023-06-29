using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Data;
using UserTest.Dto;
using UserTest.Interface;

namespace UserTest.Services
{
    public class UserService : IUserService
    {
        public UserManager<AppUser> _userManager;
        public SignInManager<AppUser> _signInManager;

        public UserService(UserManager <AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager; ;


        }
        public static List<UserDto> User { get; set; } = new List<UserDto>(); 
        
        public async Task<UserDto> AddUser (UserDto userDto)

        {
            var user = new AppUser()
            {
                UserName = userDto.Email,
                Email = userDto.Email,
                Firstname = userDto.FirstName,
                Lastname   = userDto.LastName
                
            };

            var result = await _userManager.CreateAsync(user, "P@sswOrd");
            
            if (result.Succeeded)
            {
                return userDto;
            }

            return null;
        }


        public async Task<List<UserDto>> GetUser()

        {
            
            return User; 
        }

        public async Task<UserDto> FindByEmail(string email)
        {
            return User.Where(x => x.Email.ToLower().Trim() == email.ToLower().Trim()).FirstOrDefault();
        }
    }
}
