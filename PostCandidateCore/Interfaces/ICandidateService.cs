using PostCandidateCore.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostCandidateCore.Interfaces
{
    public interface ICandidateService
    {
        Task<CandidateDto> AddUser(CandidateDto candidateDto);
        Task<List<CandidateDto>> GetUser();
    }
}
