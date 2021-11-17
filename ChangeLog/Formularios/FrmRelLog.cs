﻿using ChangeLog.Entidades.RDLC;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Formularios
{
   public partial class FrmRelLog : Form
   {
      private List<Log> ListLog;
      private string LoginUsuario;

      public FrmRelLog(List<Log> list, string loginUsuario)
      {
         InitializeComponent();
         this.ListLog = list;
         this.LoginUsuario = loginUsuario;
      }

      private void FrmRelLog_Load(object sender, EventArgs e)
      {
         List<LogDTS> list = new List<LogDTS>();

         foreach (Log log in this.ListLog)
         {
            LogDTS obj = new LogDTS();

            obj.Tipo = log.Tipo.ToString();
            obj.Titulo = log.Titulo;
            obj.Sprint = log.Sprint;
            obj.Descricao = log.Descricao;
            obj.LoginUsuario = this.LoginUsuario;
            obj.DataHora = DateTime.Now;

            list.Add(obj);
         }

         LogDTSBindingSource.DataSource = list;
         this.RVLog.RefreshReport();
      }
   }
}
