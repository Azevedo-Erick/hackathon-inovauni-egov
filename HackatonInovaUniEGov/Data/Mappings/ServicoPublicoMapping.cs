using HackatonInovaUniEGov.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HackatonInovaUniEGov.Data.Mappings;

public class ServicoPublicoMapping : IEntityTypeConfiguration<ServicoPublico>
{
    public void Configure(EntityTypeBuilder<ServicoPublico> builder)
    {
        builder.ToTable("servicos_publicos");
        builder.Property(e => e.Id)
            .HasColumnName("id");
        builder.Property(e => e.Nome)
            .HasColumnName("nome");
        
        
        builder.Property(e => e.PontosPorAvaliar)
            .HasColumnName("pontos_avaliar");
        
        builder.Property(e => e.ImageUrl)
            .HasColumnName("image_url");

        builder.HasOne(e => e.Categoria)
            .WithMany(x => x.ServicosPublicos);
    }
}