using Empleado23AM.Entities;
using Microsoft.EntityFrameworkCore;

namespace Empleado23AM.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost; database=23cv; user=root; password=;");
        }

        public DbSet<Empleado> Empleados { get; set; }







    }
}
