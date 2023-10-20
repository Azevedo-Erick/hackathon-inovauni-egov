using HackatonInovaUniEGov.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HackatonInovaUniEGov.Data.Mappings;

public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("usuarios");
        
        builder.Property(e => e.Id)
            .HasColumnName("id");
        
        builder.Property(e => e.Pontos)
            .HasColumnName("pontos");
        
        builder.Property(e => e.Cpf)
            .HasColumnName("cpf");
        
        builder.Property(e => e.Email)
            .HasColumnName("email");
        
        builder.Property(e => e.Telefone)
            .HasColumnName("telefone");
        
        
        builder.Property(e => e.Nome)
            .HasColumnName("nome");
        
    }
}