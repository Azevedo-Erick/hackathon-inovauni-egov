using HackatonInovaUniEGov.Models;
using HackatonInovaUniEGov.Models.Enums;
using HackatonInovaUniEGov.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HackatonInovaUniEGov.Data.Mappings;

public class QuestaoMapping: IEntityTypeConfiguration<Questao>
{
    public void Configure(EntityTypeBuilder<Questao> builder)
    {
        builder.ToTable("questoes");


        builder.Property(e => e.Id)
            .HasColumnName("id");
        
        builder.Property(e => e.slug)
            .HasColumnName("slug");
        
        builder.Property(e => e.TipoPergunta)
            .HasConversion(
                v => v.ToString(),
                v => (ETipoPergunta)Enum.Parse(typeof(ETipoPergunta), v));
   
        builder.Property(e => e.Texto)
            .HasColumnName("texto");

        
        
        // builder.Property(x => x.MostarMediaNoPortal).HasColumnName("mostrar_media_no_portal").HasColumnType("tinyint");
        //
        // builder.Property(x => x.TituloParaOPortal).HasColumnName("titulo_portal").HasColumnType("nvarchar");
        
        builder.HasOne(e => e.CategoriaServicoPublico)
            .WithMany(x => x.Questoes);
        
      
    }
}