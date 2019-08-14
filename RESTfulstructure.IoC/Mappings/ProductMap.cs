using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RESTfulstructure.Domain.Models;

namespace RESTfulstructure.Infra.Mappings
{
    public class ProductMap : MapBase<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.ToTable("Produto");
            builder.Property(x => x.Descricao).IsRequired().HasColumnType("varchar(50)").HasColumnName("DESCRICAO");
            builder.Property(x => x.Arquivo).IsRequired().HasColumnType("varchar(max)").HasColumnName("ARQUIVO");
            builder.Property(x => x.MidiaId).HasColumnName("MIDIA_ID");
        }
    }
}
