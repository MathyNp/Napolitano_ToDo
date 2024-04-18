using LabIV_01.Data;
using LabIV_01.Interfaces;
using LabIV_01.Models;
using LabIV_01.Models.Dto;
using LabIV_01.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace LabIV_01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly ToDoContext _toDoContext;

        public UserController(IUserService userService, ToDoContext context)
        {
            _userService = userService;
            _toDoContext = context;
        }

        [HttpPost("Crear Usuario")]
        public ActionResult CreateUser([FromBody] CreateUserDTO userDTO)
        {
            try
            {
                _userService.CreateUser(userDTO);
                return Ok($"Usuario {userDTO.Name} creado correctamente.");
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Listar Usuarios")]
        public IActionResult GetAllUsers()
        {
            try
            {
                var listUsers = _userService.GetAllUsers();
                return Ok(listUsers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Crear ToDoItem")]
        public IActionResult AddToDoItem(int userId, [FromBody] CreateToDoItemDTO newItemDto)
        {
            try
            {
                _userService.AddToDoItem(userId, newItemDto);
                return Ok($"ToDoItem creado correctamente.");
            }
            
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }






    }

   
}
