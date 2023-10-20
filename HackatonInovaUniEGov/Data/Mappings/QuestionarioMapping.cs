using HackatonInovaUniEGov.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HackatonInovaUniEGov.Data.Mappings;

public class QuestionarioMapping : IEntityTypeConfiguration<Questionario>
{
    public void Configure(EntityTypeBuilder<Questionario> builder)
    {
        builder.ToTable("questionario");


        builder.Property(e => e.Id)
            .HasColumnName("id");
        
        builder.Property(e => e.AvaliacaoMedia)
            .HasColumnName("avaliacao_media");
        
        builder.Property(e => e.ValorPontos)
            .HasColumnName("valor_pontos");
        
        builder.Property(e => e.Data)
            .HasColumnName("data");
        
        builder.HasMany(x => x.RespostasPergunta)
            .WithOne(x => x.Questionario);

        builder.HasOne(x => x.ServicoPublico).WithMany(x => x.Questionarios);
    }
}