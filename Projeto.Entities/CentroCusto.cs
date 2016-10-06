using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class CentroCusto
    {
        public int IdCentroCusto { get; set; }
        public string CentroCustoCodigo { get; set; } // 20
        public string CentroCustoDescricao { get; set; } // 100
        public string CentroCustoTipo { get; set; } //1 - Analitico ou sintetico
    }
}
