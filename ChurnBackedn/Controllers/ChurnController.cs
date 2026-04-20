using Microsoft.AspNetCore.Mvc;
using ChurnBackend.Data;
using ChurnBackend.Models;

namespace ChurnBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChurnController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ChurnController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _context.Users.ToList();
            return Ok(users);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok(user);
        }
    }
}
