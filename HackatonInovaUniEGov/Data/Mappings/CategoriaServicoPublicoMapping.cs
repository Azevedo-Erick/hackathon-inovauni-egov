using HackatonInovaUniEGov.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HackatonInovaUniEGov.Data.Mappings;

public class CategoriaServicoPublicoMapping : IEntityTypeConfiguration<CategoriaServicoPublico>
{
    public void Configure(EntityTypeBuilder<CategoriaServicoPublico> builder)
    {
        builder.ToTable("categoria_servico_publico");


        builder.Property(e => e.Id)
            .HasColumnName("id");


        builder.Property(e => e.Nome)
            .HasMaxLength(255)
            .HasColumnName("nome");
    }

}