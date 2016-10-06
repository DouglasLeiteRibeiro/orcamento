using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Entities
{
    public class ContaContabil
    {
        public int IdCentroCusto { get; set; }
        public string ContaContabilCodigo { get; set; } // 20
        public string ContaContabilDescricao { get; set; } // 100
        public string ContaContabilTipo { get; set; } //1 - Analitico ou sintetico
        public string ContaContabilCreditoDebito { get; set; } //1
    }
}
