using PostCandidateCore.Dto;
using PostCandidateCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostCandidateCore.Services
{
    public class CandidateService : ICandidateService
    {
        public static List <CandidateDto> Users { get; set; } = new List<CandidateDto>();
        public async Task<CandidateDto> AddUser (CandidateDto candidateDto)
        {
            Users.Add(candidateDto);
            return candidateDto;
        }


        public async Task<List <CandidateDto>> GetUser ()
        {
            return Users;
        }
    }
}
