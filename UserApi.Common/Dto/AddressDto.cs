using System.ComponentModel.DataAnnotations;

namespace UserApi.Common.Dto
{
    public class AddressDto
    {
        public int Id { get; set; }
        [Required]
        public string? Street { get; set; }       
        [Required]                                        
        public string? City { get; set; }   
        public int? PostCode { get; set; }
    }
}
