using System.ComponentModel.DataAnnotations;

namespace LabIV_01.Models.Dto
{
    public class CreateUserDTO
    {

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

    }
}
