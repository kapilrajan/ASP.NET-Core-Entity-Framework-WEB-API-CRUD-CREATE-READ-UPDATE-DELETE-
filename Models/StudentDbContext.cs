using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ReactAspCrud.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog=kapilDb; TrustServerCertificate=True; Integrated Security=True");   
        }
    }
}
