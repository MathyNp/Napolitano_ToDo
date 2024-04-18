using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabIV_01.Models
{
    public class ToDoItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_todo_item { get; set; }

        
        public string? Title { get; set; }

        
        public string? Description { get; set; }

      
        public int UserId { get; set; }

        public User User { get; set; }
    }
}
