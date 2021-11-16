using System;
using System.Windows.Forms;

namespace Formularios
{
   public partial class FrmLogin : Form
   {
      public FrmLogin()
      {
         InitializeComponent();
      }

      private void BtnLogin_Click(object sender, EventArgs e)
      {
         if (!string.IsNullOrEmpty(TxtUsuario.Text))
         {
            this.Hide();
            FrmRotinaChangeLog frm = new FrmRotinaChangeLog(TxtUsuario.Text);           
            frm.Show();
         }
      }

      private void BtnSair_Click(object sender, EventArgs e)
      {
         this.Dispose();
      }
   }
}
