using AuditingEntities.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonAPI.Infra.Data.Mappings
{
    public class PokemonMap : IEntityTypeConfiguration<Pokemon>, IMappings
    {
        public void Configure(EntityTypeBuilder<Pokemon> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .HasColumnName("Id");

            builder
                .Property(p => p.Name)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder
                .Property(p => p.PokemonType)
                .IsRequired();

            builder
                .HasMany(p => p.Catches)
                .WithOne(c => c.Pokemon)
                .HasForeignKey(c => c.PokemonId);
        }
    }
}
