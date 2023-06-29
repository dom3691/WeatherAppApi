using AddCandidate.Core.Dto;
using AddCandidate.Core.Interface;

namespace AddCandidate.Core.Services
{
    public class UserService : IUserService
    {
        private readonly List<UserDto> _profiles = new();

        public IEnumerable<UserDto> GetAll()
        {
            return _profiles;
        }

        public UserDto GetById(int id)
        {
            return _profiles.FirstOrDefault(p => p.Id == id);
        }

        public void Add(UserDto profile)
        {
            profile.Id = _profiles.Count + 1;
            _profiles.Add(profile);
        }

        UserDto IUserService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        //public void Add(UserDto profile)
        //{
        //    throw new NotImplementedException();
        //}

        //User IUserService.GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Add(User profile)
        //{
        //    throw new NotImplementedException();
        //}


    }
}
