using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Entidades.Arquivos
{
   public class GerarChangeLog
   {
      private FileInfo info;
      private StreamWriter Arquivo;
      private string LoginUsuario;

      public GerarChangeLog(List<Log> lista, string nomeUsuario)
      {
         this.LoginUsuario = nomeUsuario;
         this.Arquivo = CriarArquivo();
         PreencherArquivo(lista);
         MessageBox.Show("ChangeLog Gerado com Sucesso!");
      }

      private StreamWriter CriarArquivo()
      {
         string path = string.Concat(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), string.Concat("\\ChangeLogs\\ChangeLog_", DateTime.Now.ToString("dd-MM-yyyy_HH-mm"), ".txt"));

         info = new FileInfo(path);

         if (info.Exists)
            info.Delete();

         return info.CreateText();
      }

      private void PreencherArquivo(List<Log> listaCompleta)
      {
         foreach (Log log in listaCompleta)
         {
            Adicionar("__________________________________________________________________________");
            AdicionarNovaLinha();
            AdicionarNovaLinha();
            Adicionar("------------------------------------------------------");
            AdicionarNovaLinha();

            Adicionar(string.Concat("(", log.Tipo.ToString(), ") ", log.Titulo, string.Format("{0}", (string.IsNullOrEmpty(log.Sprint) ? string.Empty : string.Concat(" [", log.Sprint, "]")))));

            AdicionarNovaLinha();
            Adicionar("------------------------------------------------------");
            AdicionarNovaLinha();

            Adicionar(log.Descricao);

            AdicionarNovaLinha();
         }

         AdicionarNovaLinha();
         Adicionar("__________________________________________________________________________");
         AdicionarNovaLinha();
         Adicionar(string.Concat("Arquivo Gerado por ", this.LoginUsuario, " no Dia ", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")));

         this.Arquivo.Close();
      }

      private int Adicionar(string descricao)
      {
         this.Arquivo.Write(descricao);
         return descricao.Length;
      }

      private void AdicionarNovaLinha()
      {
         this.Arquivo.WriteLine();
      }
   }
}
