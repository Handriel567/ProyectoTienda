using Microsoft.EntityFrameworkCore;
using TiendaProyecto.Models;



namespace TiendaProyecto.Data
{



    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets para tus entidades
        public DbSet<User> Enrollment { get; set; } // Ejemplo de entidad
        // Agrega más DbSets para otras tablas en tu base de datos
    }
}
