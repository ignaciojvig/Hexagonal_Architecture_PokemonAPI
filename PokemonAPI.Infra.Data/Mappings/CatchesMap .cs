using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PokemonAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonAPI.Infra.Data.Mappings
{
    public class CatchesMap : IEntityTypeConfiguration<Catches>, IMappings
    {
        public void Configure(EntityTypeBuilder<Catches> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .Property(c => c.Id)
                .HasColumnName("Id");

            builder
                .HasOne(c => c.Trainer)
                .WithMany(t => t.Catches)
                .HasForeignKey(c => c.TrainerId);

            builder
                .HasOne(c => c.Pokemon)
                .WithMany(t => t.Catches)
                .HasForeignKey(c => c.PokemonId);
        }
    }
}
