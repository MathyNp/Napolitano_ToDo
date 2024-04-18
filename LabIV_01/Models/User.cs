using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabIV_01.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_user { get; set; }

   
        public string Name { get; set; }

        
        [EmailAddress]
        public string Email { get; set; }

    
        public string Address { get; set; }

        public List<ToDoItem> ToDoItems { get; set; } = new List<ToDoItem>();
    }
}
