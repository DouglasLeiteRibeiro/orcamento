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
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {
            ToTable("USUARIO");
            HasKey(u => u.IdUsuario); // Chave Primaria

            // Campos
            Property(u => u.IdUsuario)
                .HasColumnName("IdUsuario")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); // AutoIncremental

            Property(u => u.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .IsRequired();

            Property(u => u.Login)
                .HasColumnName("Login")
                .HasMaxLength(20)
                .IsRequired();

            Property(u => u.Email)
                .HasColumnName("Email")
                .HasMaxLength(50)
                .IsRequired();

            Property(u => u.Senha)
                .HasColumnName("Senha")
                .HasMaxLength(10)
                .IsRequired();

            Property(u => u.TipoUsuario)
                .HasColumnName("TipoUsuario")
                .IsRequired();

            Property(u => u.DataCadastro)
                .HasColumnName("DataCadastro")
                .IsRequired();

            // Parei aula 12 pag 8
               
        }
    }
}
