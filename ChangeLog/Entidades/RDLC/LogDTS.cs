using System;

namespace Entidades.Suprimentos.Reports
{
   public class LogDTS
   {
      #region Variaveis

      public int CodigoNota { get; set; }

      public int CodigoConta { get; set; }

      public int ParcelaFatura { get; set; }

      public int? CodigoCaixa { get; set; }

      public int? CodigoEventoSocial { get; set; }

      public long MatriculaFornecedor { get; set; }

      public decimal ValorNota { get; set; }

      public decimal ValorFatura { get; set; }

      public decimal ValorConta { get; set; }

      public decimal ValorTotalFatura { get; set; }

      public string NumeroNota { get; set; }

      public string NomeFornecedor { get; set; }

      public string DescricaoEventoSocial { get; set; }

      public string DescricaoConta { get; set; }

      public string Observacoes { get; set; }

      public string StringParcelaFatura { get; set; }

      public string SituacaoFatura { get; set; }

      public string DataPagamentoFatura { get; set; }

      public string TipoFormaPagamento { get; set; }

      #endregion

      #region Datas

      public DateTime DataEmissao { get; set; }

      public DateTime DataCompetencia { get; set; }

      public DateTime DataVencimentoFatura { get; set; }

      #endregion
   }
}
