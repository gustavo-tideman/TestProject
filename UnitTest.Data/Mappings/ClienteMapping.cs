using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UnitTest.Data.Model;

namespace UnitTest.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Sobrenome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.DataNascimento)
                .IsRequired()
                .HasColumnType("Datetime");

            builder.Property(c => c.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(c => c.Telefone)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(c => c.CPF)
                .IsRequired()
                .HasColumnType("varchar(14)");

            builder.ToTable("Cliente");
        }
    }
}