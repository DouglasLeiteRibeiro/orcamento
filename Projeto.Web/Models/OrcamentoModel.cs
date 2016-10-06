using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Projeto.Entities.Types;
using Projeto.Entities;

namespace Projeto.Web.Models
{
    public class OrcamentoViewModelCadastro
    {

        //public int IdOrcamento { get; set; }

        [Required(ErrorMessage = "Por favor, informe revisão.")]
        [Display(Name = "Revisão:")]
        public Revisao Revisao { get; set; }

        [Required(ErrorMessage = "Por favor, informe o centro de custo.")]
        [Display(Name = "Centro de Custo:")]
        public int IdCentroDeCusto { get; set; }

        [Required(ErrorMessage = "Por favor, informe a conta contabil.")]
        [Display(Name = "Conta Contabil:")]
        public int IdContaContabil { get; set; }

        [Required(ErrorMessage = "Por favor, informe a filial.")]
        [Display(Name = "Filial:")]
        public Filial Filial { get; set; }

        [Required(ErrorMessage = "Por favor, informe o tipo de analise.")]
        [Display(Name = "Tipo de Analise:")]
        public TipoAnalise TipoAnalise { get; set; }

        [Required(ErrorMessage = "Por favor, informe o tipo de conta.")]
        [Display(Name = "Tipo de Conta:")]
        public TipoConta TipoConta { get; set; }

        // public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Por favor, informe a quantidade.")]
        [Display(Name = "Quantidade Janeiro:")]
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

        public Usuario Usuario { get; set; }

    }

    public class OrcamentoViewModelConsulta
    {
    }
}