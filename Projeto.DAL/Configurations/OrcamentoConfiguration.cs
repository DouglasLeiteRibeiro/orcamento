using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration; //Mapeamento
using System.ComponentModel.DataAnnotations;
using Projeto.Entities; //Entidades
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.DAL.Configurations
{
    public class OrcamentoConfiguration : EntityTypeConfiguration<Orcamento>
    {
        public OrcamentoConfiguration()
        {
            ToTable("ORCAMENTO"); // Noma da Tabela

            HasKey(o => o.IdOrcamento); // Chave Primaria

            // Campos

            Property(o => o.IdOrcamento)
                .HasColumnName("IdOrcamento")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(o => o.Revisao)
                .HasColumnName("Revisao")
                .IsRequired();

            Property(o => o.IdCentroDeCusto)
                .HasColumnName("IdCentroDeCusto")
                .IsRequired();

            Property(o => o.IdContaContabil)
                .HasColumnName("IdContaContabil")
                .IsRequired();

            Property(o => o.Filial)
                .HasColumnName("Filial")
                .IsRequired();

            Property(o => o.TipoAnalise)
                .HasColumnName("TipoAnalise")
                .IsRequired();

            Property(o => o.TipoConta)
                .HasColumnName("TipoConta")
                .IsRequired();

            Property(o => o.QuantidadeJan)
                .HasColumnName("QuantidadeJan")
                .IsRequired();

            Property(o => o.ValorJan)
                .HasColumnName("ValorJan")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(o => o.QuantidadeFev)
                .HasColumnName("QuantidadeFev")
                .IsRequired();

            Property(o => o.ValorFev)
                .HasColumnName("ValorFev")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(o => o.QuantidadeMar)
                .HasColumnName("QuantidadeMar")
                .IsRequired();

            Property(o => o.ValorMar)
                .HasColumnName("ValorMar")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(o => o.QuantidadeAbr)
                .HasColumnName("QuantidadeAbr")
                .IsRequired();

            Property(o => o.ValorAbr)
                .HasColumnName("ValorAbr")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(o => o.QuantidadeMai)
                .HasColumnName("QuantidadeMai")
                .IsRequired();

            Property(o => o.ValorMai)
                .HasColumnName("ValorMai")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(o => o.QuantidadeJun)
                .HasColumnName("QuantidadeJun")
                .IsRequired();

            Property(o => o.ValorJun)
                .HasColumnName("ValorJun")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(o => o.QuantidadeJul)
                .HasColumnName("QuantidadeJul")
                .IsRequired();

            Property(o => o.ValorJul)
                .HasColumnName("ValorJul")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(o => o.QuantidadeAgo)
                .HasColumnName("QuantidadeAgo")
                .IsRequired();

            Property(o => o.ValorAgo)
                .HasColumnName("ValorAgo")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(o => o.QuantidadeSet)
                .HasColumnName("QuantidadeSet")
                .IsRequired();

            Property(o => o.ValorSet)
                .HasColumnName("ValorSet")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(o => o.QuantidadeOut)
                .HasColumnName("QuantidadeOut")
                .IsRequired();

            Property(o => o.ValorOut)
                .HasColumnName("ValorOut")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(o => o.QuantidadeNov)
                .HasColumnName("QuantidadeNov")
                .IsRequired();

            Property(o => o.ValorNov)
                .HasColumnName("ValorNov")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(o => o.QuantidadeDez)
                .HasColumnName("QuantidadeDez")
                .IsRequired();

            Property(o => o.ValorDez)
                .HasColumnName("ValorDez")
                .HasPrecision(18, 2)
                .IsRequired();

            Property(o => o.DataCriacao)
                .HasColumnName("DataCriacao")
                .IsRequired();

            Property(o => o.IdUsuario)
                .HasColumnName("IdUsuario")
                .IsRequired();

            HasRequired(o => o.Usuario) // O Orçamento tem 1 usuário
                .WithMany(u => u.Orcamentos) // o usuário tem muitos orçamentos 
                .HasForeignKey(o => o.IdUsuario); // Chave estrnageira é  IdUsuario
        }
    }
}
