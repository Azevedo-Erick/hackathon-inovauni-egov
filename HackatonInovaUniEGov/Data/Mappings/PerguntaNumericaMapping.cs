using HackatonInovaUniEGov.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HackatonInovaUniEGov.Data.Mappings;

public class PerguntaNumericaMapping : IEntityTypeConfiguration<PerguntaNumerica>
{
    public void Configure(EntityTypeBuilder<PerguntaNumerica> builder)
    {
        builder.ToTable("pergunta_numerica");


        builder.Property(e => e.Id)
            .HasColumnName("id");


        builder.Property(e => e.Questao)
            .HasMaxLength(255)
            .HasColumnName("questao");
        
        builder.Property(e => e.Nota)
            .HasMaxLength(255)
            .HasColumnName("nota");
    }
}