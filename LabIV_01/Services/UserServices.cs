using LabIV_01.Data;
using LabIV_01.Interfaces;
using LabIV_01.Models;
using LabIV_01.Models.Dto;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace LabIV_01.Services
{
    public class UserServices : IUserService
    {
        private readonly ToDoContext _context;

        public UserServices(ToDoContext context)
        {
            _context = context;
        }


        public void CreateUser(CreateUserDTO userDto)
        {
            var newUser = new User
            {
                Name = userDto.Name,
                Email = userDto.Email,
                Address = userDto.Address,
            };
        }

        public List<User> GetAllUsers() 
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int userId)
        {
            return _context.Users.FirstOrDefault(u => u.Id_user == userId);

        }
        public void AddToDoItem(int userId, CreateToDoItemDTO newItemDto)
        {
            var user = GetUserById(userId);
            if (user != null)
            {
                var newItem = new ToDoItem
                {
                    Title = newItemDto.Title,
                    Description = newItemDto.Description,
                    UserId = userId
                };

                user.ToDoItems.Add(newItem);
                _context.SaveChanges();
            }
            
        }






    }
}
