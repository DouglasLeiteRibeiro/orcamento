using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Entities.Types;

namespace Projeto.Entities
{
    public class Orcamento
    {
        public int IdOrcamento { get; set; }
        public Revisao Revisao { get; set; }
        public int IdCentroDeCusto { get; set; }
        public int IdContaContabil { get; set; }
        public Filial Filial { get; set; }
        public TipoAnalise TipoAnalise { get; set; }
        public TipoConta TipoConta { get; set; }

        public int IdUsuario { get; set; }

        public int QuantidadeJan { get; set; }
        public decimal ValorJan { get; set; }
        
        public int QuantidadeFev { get; set; }
        public decimal ValorFev { get; set; }

        public int QuantidadeMar { get; set; }
        public decimal ValorMar { get; set; }

        public int QuantidadeAbr { get; set; }
        public decimal ValorAbr { get; set; }

        public int QuantidadeMai { get; set; }
        public decimal ValorMai { get; set; }

        public int QuantidadeJun { get; set; }
        public decimal ValorJun { get; set; }

        public int QuantidadeJul { get; set; }
        public decimal ValorJul { get; set; }

        public int QuantidadeAgo { get; set; }
        public decimal ValorAgo { get; set; }

        public int QuantidadeSet { get; set; }
        public decimal ValorSet { get; set; }

        public int QuantidadeOut { get; set; }
        public decimal ValorOut { get; set; }

        public int QuantidadeNov { get; set; }
        public decimal ValorNov { get; set; }

        public int QuantidadeDez { get; set; }
        public decimal ValorDez { get; set; }
        
        public DateTime DataCriacao { get; set; }

        #region Relacionamentos

        public virtual Usuario Usuario { get; set; }

        #endregion


    }
}
