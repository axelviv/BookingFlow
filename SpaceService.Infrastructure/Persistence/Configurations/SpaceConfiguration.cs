using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpaceService.Domain.Entities;

namespace SpaceService.Infrastructure.Persistence.Configurations
{
    public class SpaceConfiguration : IEntityTypeConfiguration<Space>
    {
        public void Configure(EntityTypeBuilder<Space> builder)
        {
            // Tabla y esquema
            builder.ToTable("Spaces", "Space", t =>
            {
                // Restricciones 
                t.HasCheckConstraint("CK_Space_Capacity", "[Capacity] > 0");
                t.HasCheckConstraint("CK_Space_Price", "[Price] >= 0");
            });

            // Clave primaria
            builder.HasKey(s => s.Id);

            // Índices
            builder.HasIndex(s => s.Name);
            builder.HasIndex(s => s.Type);
            builder.HasIndex(s => s.IsActive);

            // Name
            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Name");

            // Type (enum) 
            builder.Property(s => s.Type)
                .HasConversion<int>()
                .IsRequired();

            // Description 
            builder.Property(s => s.Description)
                .HasMaxLength(500)
                .HasColumnType("nvarchar(500)")
                .HasColumnName("Description");

            // Capacity
            builder.Property(s => s.Capacity)
                .IsRequired();

            // Price 
            builder.Property(s => s.Price)
                .HasPrecision(18, 2)
                .IsRequired();

            // IsActive 
            builder.Property(s => s.IsActive)
                .HasDefaultValue(true)
                .IsRequired();            
            
            // Fechas
            builder.Property(s => s.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()")
                .IsRequired();

            builder.Property(s => s.UpdatedAt);
        }
    }
}