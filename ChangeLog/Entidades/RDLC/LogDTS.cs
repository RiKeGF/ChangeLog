using Entidades.Enumeradores;
using System;

namespace Entidades.RDLC
{
   public class LogDTS
   {
      public string Titulo { get; set; }

      public string Descricao { get; set; }

      public string Sprint { get; set; }

      public string LoginUsuario { get; set; }

      public Tipo Tipo { get; set; }

      public DateTime DataHora { get; set; }

   }
}
