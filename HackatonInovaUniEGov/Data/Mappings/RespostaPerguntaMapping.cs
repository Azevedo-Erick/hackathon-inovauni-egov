using HackatonInovaUniEGov.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HackatonInovaUniEGov.Data.Mappings;

public class RespostaPerguntaMapping : IEntityTypeConfiguration<RespostaPergunta>
{
    public void Configure(EntityTypeBuilder<RespostaPergunta> builder)
    {
        builder.ToTable("respostas_perguntas");


        builder.Property(e => e.Id)
            .HasColumnName("id");


        builder.HasOne(e => e.Questao)
            .WithMany(x=>x.RespostasPerguntas);
        
        builder.Property(e => e.Nota)
            .HasMaxLength(255)
            .HasColumnName("nota");
        

    }
}