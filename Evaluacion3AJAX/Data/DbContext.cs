using Microsoft.EntityFrameworkCore;
using Evaluacion3AJAX.Models;

namespace Evaluacion3AJAX.Data
{
    public class ProyectoDbContext : DbContext
    {
        public ProyectoDbContext(DbContextOptions<ProyectoDbContext> options) : base(options)
        {
        }

        public DbSet<Herramienta> Herramientas { get; set; }
        public DbSet<UnidadHerramienta> UnidadHerramientas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<AsignacionHerramienta> AsignacionHerramientas { get; set; }
        public DbSet<MantenimientoHerramienta> MantenimientoHerramientas { get; set; }

    }

}
