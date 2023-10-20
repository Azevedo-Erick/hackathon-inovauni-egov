using HackatonInovaUniEGov.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HackatonInovaUniEGov.Data.Mappings;

public class PerguntaTextualMapping  : IEntityTypeConfiguration<PerguntaTextual>
{
    public void Configure(EntityTypeBuilder<PerguntaTextual> builder)
    {
        builder.ToTable("pergunta_texual");


        builder.Property(e => e.Id)
            .HasColumnName("id");


        builder.Property(e => e.Questao)
            .HasMaxLength(255)
            .HasColumnName("questao");
        
        builder.Property(e => e.Responsta)
            .HasMaxLength(255)
            .HasColumnName("resposta");
    }
}