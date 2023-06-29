using AddCandidate.Core.Dto;

namespace AddCandidate.Core.Interface
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetAll();
        UserDto GetById(int id);
        void Add(UserDto profile);
        // void SaveChanges();
    }
}
