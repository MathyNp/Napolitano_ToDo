using LabIV_01.Models;
using LabIV_01.Models.Dto;

namespace LabIV_01.Interfaces
{
    public interface IUserService 
    {
        public void CreateUser(CreateUserDTO userDto);
        public List<User> GetAllUsers();
        public User GetUserById(int userId);
        public void AddToDoItem(int userId, CreateToDoItemDTO newItemDto);


       
    }
}
