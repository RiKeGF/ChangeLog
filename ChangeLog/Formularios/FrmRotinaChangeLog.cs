using Entidades;
using Entidades.Arquivos;
using Entidades.Enumeradores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Formularios
{
   public partial class FrmRotinaChangeLog : Form
   {
      private string LoginUsuario;
      private Log Registro = new Log();
      private List<Log> ListaRegistros = new List<Log>();

      public FrmRotinaChangeLog(string login)
      {
         InitializeComponent();
         this.LoginUsuario = login;
         CmbTipo.DataSource = Enum.GetValues(typeof(Tipo));
         Bind();
      }

      #region Bind

      private void Bind()
      {
         TxtTitulo.DataBindings.Clear();
         TxtDescricao.DataBindings.Clear();
         TxtSprint.DataBindings.Clear();
         CmbTipo.DataBindings.Clear();

         TxtTitulo.DataBindings.Add("Text", this.Registro, "Titulo", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
         TxtDescricao.DataBindings.Add("Text", this.Registro, "Descricao", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
         TxtSprint.DataBindings.Add("Text", this.Registro, "Sprint", true, DataSourceUpdateMode.OnPropertyChanged, string.Empty);
         CmbTipo.DataBindings.Add("SelectedItem", this.Registro, "Tipo", false, DataSourceUpdateMode.OnPropertyChanged);
      }

      #endregion

      #region Ações

      private void Adicionar()
      {
         this.ListaRegistros.Add(this.Registro);
         this.Registro = new Log();
         Bind();
      }

      private void Editar()
      {
         this.Hide();
         FrmEdicao frm = new FrmEdicao(this.ListaRegistros);
         if (frm.ShowDialog().Equals(DialogResult.OK))
            this.Show();
      }

      private void Gerar()
      {
         new GerarChangeLog(this.ListaRegistros, this.LoginUsuario);
      }

      private void Cancelar()
      {
         this.Registro = new Log();
         this.ListaRegistros = new List<Log>();
         Bind();
      }

      #endregion

      #region Eventos de Cliques

      private void BtnAdicionar_Click(object sender, EventArgs e)
      {
         if (!string.IsNullOrEmpty(this.Registro.Titulo) && !string.IsNullOrEmpty(this.Registro.Descricao))
            Adicionar();
      }

      private void BtnEditar_Click(object sender, EventArgs e)
      {
         Editar();
      }

      private void BtnGerar_Click(object sender, EventArgs e)
      {
         if (this.ListaRegistros.Count > 0)
            Gerar();
      }

      private void BtnCancelar_Click(object sender, EventArgs e)
      {
         Cancelar();
      }

      private void BtnSair_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      #endregion

      private void CmbTipo_SelectionChangeCommitted(object sender, EventArgs e)
      {
         this.Registro.Tipo = (Tipo)CmbTipo.SelectedItem;
      }

      private void FrmRotinaChangeLog_FormClosed(object sender, FormClosedEventArgs e)
      {
         Application.Exit();
      }
   }
}
