using Commander.Data;
using UserModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Commander.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;

namespace Commander.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserRepo _repository;
        private readonly IMapper _mapper;

        public UserController(IUserRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        // GET: api/User
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            List<User> user = await _repository.GetUsers();
            return Ok(user);
        }
        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            User? userDto = await _repository.GetUserById(id);
            return userDto != null ? Ok(userDto) : NotFound();
        }
        
    }
}