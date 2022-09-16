using CDub_Blazor_Crud.Models;
using Microsoft.EntityFrameworkCore;

namespace CDub_Blazor_Crud.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
    }
}
