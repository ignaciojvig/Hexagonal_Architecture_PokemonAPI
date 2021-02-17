using AuditingEntities.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonAPI.Infra.Data.Mappings
{
    public class TrainerMap : IEntityTypeConfiguration<Trainer>, IMappings
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.HasKey(t => t.Id);

            builder
                .Property(t => t.Id)
                .HasColumnName("Id");

            builder
                .Property(t => t.Name)
                .HasColumnType("varchar(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(t => t.TrainerClass)
                .IsRequired();

            builder
                .HasMany(t => t.Catches)
                .WithOne(c => c.Trainer)
                .HasForeignKey(c => c.TrainerId);
        }
    }
}
