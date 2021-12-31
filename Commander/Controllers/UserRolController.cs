using Commander.Data;
using UserModel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Commander.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using UserRolModel.Models;

namespace Commander.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolController : ControllerBase
    {
        private readonly IUserRolRepo _repository;
        private readonly IMapper _mapper;

        public UserRolController(IUserRolRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        // GET: api/User
        [HttpGet]
        public async Task<IActionResult> GetUserRol()
        {
            List<UserRol> userRol = await _repository.GetUserRol();
            return Ok(userRol);
        }
        // GET: api/User/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserRolById(int id)
        {
            UserRol? userRolDto = await _repository.GetUserRolById(id);
            return userRolDto != null ? Ok(userRolDto) : NotFound();
        }
    }
}