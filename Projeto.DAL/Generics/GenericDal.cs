using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Projeto.DAL.DataSource;

namespace Projeto.DAL.Generics
{
    public abstract class GenericDal<TEntity>
        where TEntity : class
    {
        public virtual void Insert(TEntity obj)
        {
            using (Conexao Con = new Conexao())
            {
                Con.Entry(obj).State = EntityState.Added;
                Con.SaveChanges();
            }
        }
    }
}
