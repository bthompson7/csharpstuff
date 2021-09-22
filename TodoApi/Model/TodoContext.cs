using Microsoft.EntityFrameworkCore;

namespace TodoApi.Model
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> TodoItems { get; set; }
    }
}