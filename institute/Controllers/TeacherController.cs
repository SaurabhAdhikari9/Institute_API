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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IEnumerable<Teacher>> Get()
        {
            return await _context.Teachers.ToListAsync();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Teacher), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById(int id)
        {
            var teacher = await _context.Teachers.FindAsync(id);
            
            return (teacher == null) ? NotFound(): Ok(teacher);

        }

    }
}
