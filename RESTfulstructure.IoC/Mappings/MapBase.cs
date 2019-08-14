using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RESTfulstructure.Domain.Models;

namespace RESTfulstructure.Infra.Mappings
{
    public class MapBase<T> : IEntityTypeConfiguration<T>
        where T : EntityBase
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).IsRequired().HasColumnName("ID");
            builder.Property(c => c.DateCreation).HasColumnType("datetime2(0)").HasColumnName("DATA_CRIACAO");
            builder.Property(c => c.DateChange).HasColumnType("datetime2(0)").HasColumnName("DATA_ALTERACAO");
        }
    }
}
