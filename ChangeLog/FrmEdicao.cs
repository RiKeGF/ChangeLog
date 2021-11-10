using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeLog
{
   public partial class FrmEdicao : Form
   {
      private List<Log> ListaRegistros;
      private Log RegistroSelecionado;

      public FrmEdicao(List<Log> lista)
      {
         InitializeComponent();
         this.ListaRegistros = lista;
         DgvListaRegistros.AutoGenerateColumns = false;
         AtualizarDataGridView();
      }

      private void AtualizarDataGridView()
      {
         DgvListaRegistros.DataSource = this.ListaRegistros.ToList();
         DgvListaRegistros.Refresh();

         if (this.ListaRegistros.Count == 0)
            TxtDescricao.Text = string.Empty;
      }

      private void BtnFechar_Click(object sender, EventArgs e)
      {
         this.DialogResult = DialogResult.OK;
      }

      private void DgvListaRegistros_CellEnter(object sender, DataGridViewCellEventArgs e)
      {
         if (this.ListaRegistros.Count > 0)
         {
            this.RegistroSelecionado = (Log)DgvListaRegistros.CurrentRow.DataBoundItem;
            TxtDescricao.Text = this.RegistroSelecionado.Descricao;
         }
      }

      private void BtnExcluir_Click(object sender, EventArgs e)
      {
         if (DgvListaRegistros.RowCount > 0 && this.RegistroSelecionado != null)
            this.ListaRegistros.Remove(this.RegistroSelecionado);
         AtualizarDataGridView();
      }
   }
}
