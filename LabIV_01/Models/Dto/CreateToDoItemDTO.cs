using System.ComponentModel.DataAnnotations;

namespace LabIV_01.Models.Dto
{
    public class CreateToDoItemDTO
    {
        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Description { get; set; }
    }
}
