using AuditingEntities.Domain.Enums;
using AuditingEntities.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonAPI.Infra.Data.Seeding
{
    public static class Seeding
    {
        public static void ApplySeeding(this ModelBuilder modelBuilder)
        {
            modelBuilder.SeedBusinessEntities();
        }

        public static void SeedBusinessEntities(this ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Trainer>()
                .HasData(
                new Trainer(new Guid("{48946519-DED7-4752-92F8-67B133644631}"), "Ash Ketchum", TrainerClass.Trainer),
                new Trainer(new Guid("{8E7A6390-D2A2-437A-8CBF-A4D17F457ABE}"), "Red", TrainerClass.Pokemon_Master));

            modelBuilder
                .Entity<Pokemon>()
                .HasData(
                new Pokemon(new Guid("{46BCFB9B-7E9C-4A22-BAEB-048262BBA83A}"), "Bulbasaur", PokemonType.Grass),
                new Pokemon(new Guid("{C90B614C-E10F-423A-9BCB-8B8CECECACD7}"), "Charmander", PokemonType.Fire),
                new Pokemon(new Guid("{A1EBE66A-D83F-4B69-AE5D-A6A8A997FDD1}"), "Squirtle", PokemonType.Water));
        }
    }
}
