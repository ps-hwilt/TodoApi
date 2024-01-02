using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
            // TODO: finish this method
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null;
    }
}

