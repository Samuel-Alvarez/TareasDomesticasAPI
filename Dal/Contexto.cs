using AplicacionDistribuidaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AplicacionDistribuidaAPI.Dal
{
    public class Contexto : DbContext
    {
        public DbSet<Tareas> Tareas { get; set; }
        public DbSet<Empleados> Empleados { get; set; }
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tareas>().HasData(new Tareas
            {
                TareaId = 1,
                EmpleadoId = 1,
                Descripcion = "Limpiar la casa",
                Fecha = "20/12/2019",
                Nombre = "Michael",
                Estado = "Por Hacer",
                CodigoAcceso = "1234"
            });
            modelBuilder.Entity<Tareas>().HasData(new Tareas
            {
                TareaId = 2,
                EmpleadoId = 2,
                Descripcion = "Barrer",
                Fecha = "22/3/2023",
                Nombre = "Samuel",
                Estado = "Por Hacer",
                CodigoAcceso = "4321"
            });
        }
    }
}
