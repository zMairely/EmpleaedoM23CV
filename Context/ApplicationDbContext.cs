using EmpleaedoM23CV.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmpleaedoM23CV.Context
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
