using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace API.Controllers
{
    [ApiController]
    [Route("api[Controller]")]   // GET /api/users 

    public class TestController
    {
        private readonly DataContext _context;

        public TestController(DataContext context)
        {
            _context=context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AppUser>>GetUsers()
        {
            var users = _context.Users.ToList();

            return users;
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser>Getuser(int id)
        {
            return _context.Users.Find(id);
            
        }
    }
}