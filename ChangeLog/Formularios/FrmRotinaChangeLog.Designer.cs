namespace Formularios
{
   partial class FrmRotinaChangeLog
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
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.TxtTitulo = new System.Windows.Forms.TextBox();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.TxtDescricao = new System.Windows.Forms.TextBox();
         this.panel2 = new System.Windows.Forms.Panel();
         this.BtnAdicionar = new System.Windows.Forms.Button();
         this.BtnEditar = new System.Windows.Forms.Button();
         this.BtnGerar = new System.Windows.Forms.Button();
         this.BtnCancelar = new System.Windows.Forms.Button();
         this.BtnSair = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.CmbTipo = new System.Windows.Forms.ComboBox();
         this.groupBox4 = new System.Windows.Forms.GroupBox();
         this.TxtSprint = new System.Windows.Forms.TextBox();
         this.CmbTipoRelatorio = new System.Windows.Forms.ComboBox();
         this.panel1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox3.SuspendLayout();
         this.panel2.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.groupBox4.SuspendLayout();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Gadugi", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(10, 7);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(159, 32);
         this.label1.TabIndex = 0;
         this.label1.Text = "ChangeLog";
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.panel1.Controls.Add(this.label1);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(1037, 51);
         this.panel1.TabIndex = 1;
         // 
         // groupBox2
         // 
         this.groupBox2.BackColor = System.Drawing.Color.Transparent;
         this.groupBox2.Controls.Add(this.TxtTitulo);
         this.groupBox2.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox2.ForeColor = System.Drawing.Color.White;
         this.groupBox2.Location = new System.Drawing.Point(130, 57);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(641, 56);
         this.groupBox2.TabIndex = 1;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Título";
         // 
         // TxtTitulo
         // 
         this.TxtTitulo.BackColor = System.Drawing.SystemColors.Control;
         this.TxtTitulo.Location = new System.Drawing.Point(6, 22);
         this.TxtTitulo.Name = "TxtTitulo";
         this.TxtTitulo.Size = new System.Drawing.Size(625, 25);
         this.TxtTitulo.TabIndex = 0;
         // 
         // groupBox3
         // 
         this.groupBox3.BackColor = System.Drawing.Color.Transparent;
         this.groupBox3.Controls.Add(this.TxtDescricao);
         this.groupBox3.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox3.ForeColor = System.Drawing.Color.White;
         this.groupBox3.Location = new System.Drawing.Point(12, 119);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(1013, 341);
         this.groupBox3.TabIndex = 2;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Descrição";
         // 
         // TxtDescricao
         // 
         this.TxtDescricao.BackColor = System.Drawing.SystemColors.Control;
         this.TxtDescricao.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TxtDescricao.Location = new System.Drawing.Point(6, 22);
         this.TxtDescricao.Multiline = true;
         this.TxtDescricao.Name = "TxtDescricao";
         this.TxtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.TxtDescricao.Size = new System.Drawing.Size(1001, 312);
         this.TxtDescricao.TabIndex = 0;
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.CmbTipoRelatorio);
         this.panel2.Controls.Add(this.BtnAdicionar);
         this.panel2.Controls.Add(this.BtnEditar);
         this.panel2.Controls.Add(this.BtnGerar);
         this.panel2.Controls.Add(this.BtnCancelar);
         this.panel2.Controls.Add(this.BtnSair);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel2.Location = new System.Drawing.Point(0, 468);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(1037, 45);
         this.panel2.TabIndex = 5;
         // 
         // BtnAdicionar
         // 
         this.BtnAdicionar.Dock = System.Windows.Forms.DockStyle.Right;
         this.BtnAdicionar.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BtnAdicionar.ForeColor = System.Drawing.Color.Black;
         this.BtnAdicionar.Location = new System.Drawing.Point(577, 0);
         this.BtnAdicionar.Name = "BtnAdicionar";
         this.BtnAdicionar.Size = new System.Drawing.Size(92, 45);
         this.BtnAdicionar.TabIndex = 0;
         this.BtnAdicionar.Text = "Adicionar";
         this.BtnAdicionar.UseVisualStyleBackColor = true;
         this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
         // 
         // BtnEditar
         // 
         this.BtnEditar.Dock = System.Windows.Forms.DockStyle.Right;
         this.BtnEditar.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BtnEditar.ForeColor = System.Drawing.Color.Black;
         this.BtnEditar.Location = new System.Drawing.Point(669, 0);
         this.BtnEditar.Name = "BtnEditar";
         this.BtnEditar.Size = new System.Drawing.Size(92, 45);
         this.BtnEditar.TabIndex = 1;
         this.BtnEditar.Text = "Editar";
         this.BtnEditar.UseVisualStyleBackColor = true;
         this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
         // 
         // BtnGerar
         // 
         this.BtnGerar.Dock = System.Windows.Forms.DockStyle.Right;
         this.BtnGerar.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BtnGerar.ForeColor = System.Drawing.Color.Black;
         this.BtnGerar.Location = new System.Drawing.Point(761, 0);
         this.BtnGerar.Name = "BtnGerar";
         this.BtnGerar.Size = new System.Drawing.Size(92, 45);
         this.BtnGerar.TabIndex = 2;
         this.BtnGerar.Text = "Gerar";
         this.BtnGerar.UseVisualStyleBackColor = true;
         this.BtnGerar.Click += new System.EventHandler(this.BtnGerar_Click);
         // 
         // BtnCancelar
         // 
         this.BtnCancelar.Dock = System.Windows.Forms.DockStyle.Right;
         this.BtnCancelar.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BtnCancelar.ForeColor = System.Drawing.Color.Black;
         this.BtnCancelar.Location = new System.Drawing.Point(853, 0);
         this.BtnCancelar.Name = "BtnCancelar";
         this.BtnCancelar.Size = new System.Drawing.Size(92, 45);
         this.BtnCancelar.TabIndex = 3;
         this.BtnCancelar.Text = "Cancelar";
         this.BtnCancelar.UseVisualStyleBackColor = true;
         this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
         // 
         // BtnSair
         // 
         this.BtnSair.Dock = System.Windows.Forms.DockStyle.Right;
         this.BtnSair.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BtnSair.ForeColor = System.Drawing.Color.Black;
         this.BtnSair.Location = new System.Drawing.Point(945, 0);
         this.BtnSair.Name = "BtnSair";
         this.BtnSair.Size = new System.Drawing.Size(92, 45);
         this.BtnSair.TabIndex = 4;
         this.BtnSair.Text = "Sair";
         this.BtnSair.UseVisualStyleBackColor = true;
         this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
         // 
         // groupBox1
         // 
         this.groupBox1.BackColor = System.Drawing.Color.Transparent;
         this.groupBox1.Controls.Add(this.CmbTipo);
         this.groupBox1.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.ForeColor = System.Drawing.Color.White;
         this.groupBox1.Location = new System.Drawing.Point(12, 57);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(112, 56);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Tipo";
         // 
         // CmbTipo
         // 
         this.CmbTipo.BackColor = System.Drawing.SystemColors.Control;
         this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.CmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.CmbTipo.FormattingEnabled = true;
         this.CmbTipo.Location = new System.Drawing.Point(6, 22);
         this.CmbTipo.Name = "CmbTipo";
         this.CmbTipo.Size = new System.Drawing.Size(100, 25);
         this.CmbTipo.TabIndex = 0;
         this.CmbTipo.SelectionChangeCommitted += new System.EventHandler(this.CmbTipo_SelectionChangeCommitted);
         // 
         // groupBox4
         // 
         this.groupBox4.BackColor = System.Drawing.Color.Transparent;
         this.groupBox4.Controls.Add(this.TxtSprint);
         this.groupBox4.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox4.ForeColor = System.Drawing.Color.White;
         this.groupBox4.Location = new System.Drawing.Point(777, 57);
         this.groupBox4.Name = "groupBox4";
         this.groupBox4.Size = new System.Drawing.Size(248, 56);
         this.groupBox4.TabIndex = 2;
         this.groupBox4.TabStop = false;
         this.groupBox4.Text = "Sprint";
         // 
         // TxtSprint
         // 
         this.TxtSprint.BackColor = System.Drawing.SystemColors.Control;
         this.TxtSprint.Location = new System.Drawing.Point(6, 22);
         this.TxtSprint.Name = "TxtSprint";
         this.TxtSprint.Size = new System.Drawing.Size(236, 25);
         this.TxtSprint.TabIndex = 0;
         // 
         // CmbTipoRelatorio
         // 
         this.CmbTipoRelatorio.BackColor = System.Drawing.SystemColors.Control;
         this.CmbTipoRelatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.CmbTipoRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.CmbTipoRelatorio.FormattingEnabled = true;
         this.CmbTipoRelatorio.Location = new System.Drawing.Point(12, 12);
         this.CmbTipoRelatorio.Name = "CmbTipoRelatorio";
         this.CmbTipoRelatorio.Size = new System.Drawing.Size(98, 21);
         this.CmbTipoRelatorio.TabIndex = 5;
         // 
         // FrmRotinaChangeLog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
         this.ClientSize = new System.Drawing.Size(1037, 513);
         this.Controls.Add(this.groupBox4);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.panel1);
         this.ForeColor = System.Drawing.SystemColors.Control;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
         this.Name = "FrmRotinaChangeLog";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmRotinaChangeLog_FormClosed);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.groupBox3.ResumeLayout(false);
         this.groupBox3.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.groupBox1.ResumeLayout(false);
         this.groupBox4.ResumeLayout(false);
         this.groupBox4.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.TextBox TxtTitulo;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.TextBox TxtDescricao;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Button BtnCancelar;
      private System.Windows.Forms.Button BtnSair;
      private System.Windows.Forms.Button BtnGerar;
      private System.Windows.Forms.Button BtnEditar;
      private System.Windows.Forms.Button BtnAdicionar;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.ComboBox CmbTipo;
      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.TextBox TxtSprint;
      private System.Windows.Forms.ComboBox CmbTipoRelatorio;
   }
}

