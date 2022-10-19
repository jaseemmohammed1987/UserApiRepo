using System.ComponentModel.DataAnnotations;

namespace UserApi.Common.Dto
{
    public class UserDto
    {

        public UserDto()
        {
            Employments = new List<EmploymentDto>();
        }
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }  
        [Required]
        public string? LastName { get; set; } 
        public AddressDto? Address { get; set; }
        public List<EmploymentDto> Employments { get; set; } 
    }
}
