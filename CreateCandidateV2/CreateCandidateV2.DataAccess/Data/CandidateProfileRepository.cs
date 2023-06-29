using CreateCandidateV2.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCandidateV2.DataAccess.Data
{
    public class CandidateProfileRepository : ICandidateProfileRepository
    {
        private readonly List<CandidateProfile> _profiles = new();

        public IEnumerable<CandidateProfile> GetAll()
        {
            return _profiles;
        }

        public CandidateProfile GetById(int id)
        {
            return _profiles.FirstOrDefault(p => p.Id == id);
        }

        public void Add(CandidateProfile profile)
        {
            profile.Id = _profiles.Count + 1;
            _profiles.Add(profile);
        }

    }
}
