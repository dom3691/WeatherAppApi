namespace CandidateProfile.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public DateTime DateOfJoining { get; set; }
        public string? Status { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailId { get; set; }
        public int ContactNumber { get; set; }
        public string? OrganizationName { get; set; }
        public char OrganizationId { get; set; }
        public string? Address { get; set; }
    }
}
