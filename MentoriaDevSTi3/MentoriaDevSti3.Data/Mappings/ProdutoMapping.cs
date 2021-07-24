using MentoriaDevSti3.Data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MentoriaDevSti3.Data.Mappings
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            
            builder.Property(p => p.Nome).HasColumnType("varchar(255)").IsRequired();
            builder.Property(p => p.Valor).HasColumnType("decimal(15,2)").IsRequired();
        }
    }
}
