using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using institute.Data;
using institute.Models;

namespace institute.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly TeacherDbContext _context;
        
        public TeacherController(TeacherDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Teacher>> Get()
        {
            return await _context.Teachers.ToListAsync();
        }
    }
}
