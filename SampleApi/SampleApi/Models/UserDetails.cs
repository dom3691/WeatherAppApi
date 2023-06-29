using System.ComponentModel.DataAnnotations;

namespace SampleApi.Models
{
    public class UserDetails
    {
        [Key]
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? Email { get; set; }
        public string? ExamId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }

        //public static void Add(UserDetails userDetails)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
