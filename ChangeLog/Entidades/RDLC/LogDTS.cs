using System;

namespace ChangeLog.Entidades.RDLC
{
   public class LogDTS
   {
      public string Titulo { get; set; }

      public string Descricao { get; set; }

      public string Sprint { get; set; }

      public string LoginUsuario { get; set; }

      public string Tipo { get; set; }

      public string DataFormatada { get { return DataHora.ToString("dd-MM-yyyy_HH-mm"); } set { } }

      public int bilu { get; set; }

      public DateTime DataHora { get; set; }
   }
}
