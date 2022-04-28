using API_CRUD_Operation.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD_Operation.Data
{
    public class Context :DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Blog> Blogs { get; set; }
    }
}
