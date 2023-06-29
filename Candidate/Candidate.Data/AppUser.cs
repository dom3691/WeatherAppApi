using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.Data
{
    public class AppUser : IdentityUser
    {
       public string FirstName { get; set; }
       public string MiddleName { get; set; }
       public string LastName { get; set; }
       public string DateOfBirth { get; set; }
       public string Gender { get; set; }
       public string Address { get; set; }
       public string City { get; set; }
       public string ZipCode { get; set; }
       public string State { get; set; }
       public string Language { get; set; }
       public string PhoneNumber { get; set; }
       public string EmailID { get; set; }
       public string University { get; set; }
       public string Campus { get; set; }
       public string Department { get; set; }
       public string Course { get; set; }
      
       public string Subject { get; set; }
       public string Group { get; set; }
    }
}
