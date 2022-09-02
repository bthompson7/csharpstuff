using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Model;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoItemsController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems/employees
        [HttpGet("employees")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetDevelopersItems()
        {
            return await _context.TodoItems.ToListAsync();
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(long id)
        {
            var employee = await _context.TodoItems.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return employee;
        }

    
        // POST: developer     
        [HttpPost("developer")]
        public async Task<ActionResult<Developer>> PostDeveloper(Developer employee)
        {

            _context.TodoItems.Add(employee);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Developer), new { id = employee.Id }, employee);
        }

        // POST: senior developer 
        [HttpPost("seniordeveloper")]
        public async Task<ActionResult<SeniorDeveloper>> PostDeveloper(SeniorDeveloper employee)
        {
            _context.TodoItems.Add(employee);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(SeniorDeveloper), new { id = employee.Id }, employee);
        }


        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(long id)
        {
            var employee = await _context.TodoItems.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(employee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeExists(long id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }
    }
}
