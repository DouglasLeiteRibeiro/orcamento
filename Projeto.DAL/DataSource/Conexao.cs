using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration; //connectionstring..
using System.Data.Entity; //entityframework..
using System.Data.Entity.ModelConfiguration.Conventions;
using Projeto.Entities; //entidades
using Projeto.DAL.Configurations; //mapeamento..

namespace Projeto.DAL.DataSource
{
    public class Conexao  : DbContext
    {
        public Conexao()
            : base(ConfigurationManager.ConnectionStrings["Orcamento"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new OrcamentoConfiguration());

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Orcamento> Orcamento { get; set; }

    }
}
