using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
                
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
            new Villa()
            {
                Id=1,
                Nombre = "Ciudad Real",
                Detalle ="Detalle de la ciudad",
                ImagenUrl = "",
                Ocupantes= 5,
                MetrosCuadrados = 50,
                Tarifa = 200,
                Amenidad = "",
                FechaCreacion = DateTime.Now,
                FechaActualizacion = DateTime.Now, 
            },
             new Villa()
             {
                 Id = 2,
                 Nombre = "Villa Premiun gold",
                 Detalle = "Detalle de la Villa",
                 ImagenUrl = "",
                 Ocupantes = 10,
                 MetrosCuadrados = 150,
                 Tarifa = 3200,
                 Amenidad = "",
                 FechaCreacion = DateTime.Now,
                 FechaActualizacion = DateTime.Now,
             });
        }
    }
}
