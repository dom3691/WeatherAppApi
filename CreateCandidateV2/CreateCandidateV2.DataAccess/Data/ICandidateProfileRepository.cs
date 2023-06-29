using CreateCandidateV2.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCandidateV2.DataAccess.Data
{
    public interface ICandidateProfileRepository
    {
        IEnumerable<CandidateProfile> GetAll();
        CandidateProfile GetById(int id);
        void Add(CandidateProfile profile);
        void SaveChanges();
    }
}
