using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CandidateProfile.DataAccess.Data
{
    public class CandidateDbContext : DbContext
    {
       // public DbSet <CandidateProfile> Profile { get; set; }
        public CandidateDbContext(DbContextOptions<CandidateDbContext> options) : base (options)
        {

        }
    }
}
