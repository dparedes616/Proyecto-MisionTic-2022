using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public class DataContext : DbContext
    { 
        public DbSet<Municipios> Municipios {get; set;}
        public DbSet<DT> DirectoresTecnicos {get; set;}
        public DbSet<Equipos> Equipos {get; set;}
        public DbSet<Partidos> Partidos {get; set;}
        public DbSet<Posiciones> Posiciones {get; set;}
        public DbSet<Jugadores> Jugadores {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Torneo25");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                foreach (var relationship in
                modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
                    {
                        relationship.DeleteBehavior = DeleteBehavior.Restrict;
                    }
            }


    }
}