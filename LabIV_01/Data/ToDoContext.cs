using LabIV_01.Models;
using Microsoft.EntityFrameworkCore;

namespace LabIV_01.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }
   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>()
           .HasOne(ti => ti.User) 
           .WithMany(u => u.ToDoItems) 
           .HasForeignKey(ti => ti.UserId); 
        }
    }
}
