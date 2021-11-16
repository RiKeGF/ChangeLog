namespace Formularios
{
   partial class FrmLogin
   {
      /// <summary>
      /// Variável de designer necessária.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Limpar os recursos que estão sendo usados.
      /// </summary>
      /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Código gerado pelo Windows Form Designer

      /// <summary>
      /// Método necessário para suporte ao Designer - não modifique 
      /// o conteúdo deste método com o editor de código.
      /// </summary>
      private void InitializeComponent()
      {
         this.label1 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.TxtUsuario = new System.Windows.Forms.TextBox();
         this.panel2 = new System.Windows.Forms.Panel();
         this.BtnLogin = new System.Windows.Forms.Button();
         this.BtnSair = new System.Windows.Forms.Button();
         this.panel1.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.panel2.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Gadugi", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(10, 7);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(87, 32);
         this.label1.TabIndex = 0;
         this.label1.Text = "Login";
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.panel1.Controls.Add(this.label1);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(537, 51);
         this.panel1.TabIndex = 1;
         // 
         // groupBox1
         // 
         this.groupBox1.BackColor = System.Drawing.Color.Transparent;
         this.groupBox1.Controls.Add(this.TxtUsuario);
         this.groupBox1.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.ForeColor = System.Drawing.Color.White;
         this.groupBox1.Location = new System.Drawing.Point(12, 57);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(514, 56);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Nome do Usuário";
         // 
         // TxtUsuario
         // 
         this.TxtUsuario.BackColor = System.Drawing.SystemColors.Control;
         this.TxtUsuario.Location = new System.Drawing.Point(6, 22);
         this.TxtUsuario.Name = "TxtUsuario";
         this.TxtUsuario.Size = new System.Drawing.Size(502, 25);
         this.TxtUsuario.TabIndex = 0;
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.BtnLogin);
         this.panel2.Controls.Add(this.BtnSair);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel2.Location = new System.Drawing.Point(0, 126);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(537, 45);
         this.panel2.TabIndex = 5;
         // 
         // BtnLogin
         // 
         this.BtnLogin.Dock = System.Windows.Forms.DockStyle.Right;
         this.BtnLogin.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BtnLogin.ForeColor = System.Drawing.Color.Black;
         this.BtnLogin.Location = new System.Drawing.Point(353, 0);
         this.BtnLogin.Name = "BtnLogin";
         this.BtnLogin.Size = new System.Drawing.Size(92, 45);
         this.BtnLogin.TabIndex = 0;
         this.BtnLogin.Text = "Login";
         this.BtnLogin.UseVisualStyleBackColor = true;
         this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
         // 
         // BtnSair
         // 
         this.BtnSair.Dock = System.Windows.Forms.DockStyle.Right;
         this.BtnSair.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BtnSair.ForeColor = System.Drawing.Color.Black;
         this.BtnSair.Location = new System.Drawing.Point(445, 0);
         this.BtnSair.Name = "BtnSair";
         this.BtnSair.Size = new System.Drawing.Size(92, 45);
         this.BtnSair.TabIndex = 1;
         this.BtnSair.Text = "Sair";
         this.BtnSair.UseVisualStyleBackColor = true;
         this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
         // 
         // FrmLogin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
         this.ClientSize = new System.Drawing.Size(537, 171);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.ForeColor = System.Drawing.SystemColors.Control;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
         this.Name = "FrmLogin";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Button BtnLogin;
      private System.Windows.Forms.Button BtnSair;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox TxtUsuario;
   }
}

