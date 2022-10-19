namespace UserApi.Repository.Models
{
    public class User
    {
        public User()
        {
            Employments = new List<Employment>();
        }
        public int Id { get; set; }
        public string? FirstName { get; set; } 
        public string? LastName { get; set; } 
        public Address? Address { get; set; }
        public List<Employment> Employments { get; set; } 
    }
}
