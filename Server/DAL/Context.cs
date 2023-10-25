using Microsoft.EntityFrameworkCore;
using Abraham_API1_P2.Shared.Models;

namespace Abraham_API1_P2.Server.DAL
{
    public class Context : DbContext
    {
        public DbSet<Entradas> Entrada { get; set; }

        public DbSet<Productos> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Productos>().HasData(new List<Productos>()
            {
                new Productos() { ProductoId = 1, Descripción = "Maní", Tipo = 0, Existensia = 500 },
                new Productos() { ProductoId = 2, Descripción = "Pistacho", Tipo = 0, Existensia = 500 },
                new Productos() { ProductoId = 3, Descripción = "Pasas", Tipo = 0, Existensia = 500 },
                new Productos() { ProductoId = 4, Descripción = "Ciruelas", Tipo = 0, Existensia = 500 },
                new Productos() { ProductoId = 5, Descripción = "Arándanos", Tipo = 0, Existensia = 500 },
                new Productos() { ProductoId = 6, Descripción = "Mixto MPP 0.5L lb", Tipo = 1, Existensia = 0 },
                new Productos() { ProductoId = 7, Descripción = "Mixto MPC 0.5L lb", Tipo = 1, Existensia = 0 },
                new Productos() { ProductoId = 8, Descripción = "Mixto MPp 0.2L lb", Tipo = 1, Existensia = 0 },
            });

        }
        public Context(DbContextOptions<Context> options) : base(options) { }
    }

}
