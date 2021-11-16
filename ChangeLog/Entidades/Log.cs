using Entidades.Enumeradores;

namespace Entidades
{
   public class Log
   {
      public Log()
      {
         this.Tipo = Tipo.DESKTOP;
      }

      public string Titulo { get; set; }

      public string Descricao { get; set; }

      public string Sprint { get; set; }

      public Tipo Tipo { get; set; }
   }
}
