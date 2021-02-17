using AuditingEntities.Domain.Models;
using Microsoft.EntityFrameworkCore;
using PokemonAPI.Domain.Models;
using PokemonAPI.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI.Infra.Data.Context
{
    public class PokemonDbContext : DbContext, IUnitOfWork
    {

        public PokemonDbContext(DbContextOptions<PokemonDbContext> options) : base(options)
        {

        }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<Catches> Catches { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
            {
                property.SetColumnType("varchar(100)");
            }

            var mappings = (from x in Assembly.GetExecutingAssembly().GetTypes() where x.IsClass && typeof(IMappings).IsAssignableFrom(x) select x).ToList();
            foreach (var mapping in mappings)
            {
                dynamic map = Activator.CreateInstance(mapping);
                modelBuilder.ApplyConfiguration(map);
            }

            base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> Commit()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreatedAt") != null && entry.Entity.GetType().GetProperty("UpdatedAt") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedAt").CurrentValue = DateTime.Now;
                    entry.Property("UpdatedAt").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreatedAt").IsModified = false;
                    entry.Property("UpdatedAt").CurrentValue = DateTime.Now;
                }
            }

            return await base.SaveChangesAsync() > 0;
        }
    }
}
