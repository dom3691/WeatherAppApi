using CreateCandidate.Models;

namespace CreateCandidate.Data
{
    public interface ICandidateProfileRepository
    {
        IEnumerable<CandidateProfile> GetAll();
        CandidateProfile GetById(int id);
        void Add(CandidateProfile profile);
       // void SaveChanges();
    }
}
