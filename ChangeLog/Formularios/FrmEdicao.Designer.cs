namespace ChangeLog
{
   partial class FrmEdicao
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         this.label1 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.BtnExcluir = new System.Windows.Forms.Button();
         this.BtnFechar = new System.Windows.Forms.Button();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.DgvListaRegistros = new System.Windows.Forms.DataGridView();
         this.ClTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.ClSprint = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.TxtDescricao = new System.Windows.Forms.TextBox();
         this.panel1.SuspendLayout();
         this.panel2.SuspendLayout();
         this.groupBox2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.DgvListaRegistros)).BeginInit();
         this.groupBox1.SuspendLayout();
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
         // panel2
         // 
         this.panel2.Controls.Add(this.BtnExcluir);
         this.panel2.Controls.Add(this.BtnFechar);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel2.Location = new System.Drawing.Point(0, 468);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(1037, 45);
         this.panel2.TabIndex = 5;
         // 
         // BtnExcluir
         // 
         this.BtnExcluir.Dock = System.Windows.Forms.DockStyle.Right;
         this.BtnExcluir.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BtnExcluir.ForeColor = System.Drawing.Color.Black;
         this.BtnExcluir.Location = new System.Drawing.Point(853, 0);
         this.BtnExcluir.Name = "BtnExcluir";
         this.BtnExcluir.Size = new System.Drawing.Size(92, 45);
         this.BtnExcluir.TabIndex = 0;
         this.BtnExcluir.Text = "Excluir";
         this.BtnExcluir.UseVisualStyleBackColor = true;
         this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
         // 
         // BtnFechar
         // 
         this.BtnFechar.Dock = System.Windows.Forms.DockStyle.Right;
         this.BtnFechar.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.BtnFechar.ForeColor = System.Drawing.Color.Black;
         this.BtnFechar.Location = new System.Drawing.Point(945, 0);
         this.BtnFechar.Name = "BtnFechar";
         this.BtnFechar.Size = new System.Drawing.Size(92, 45);
         this.BtnFechar.TabIndex = 1;
         this.BtnFechar.Text = "Fechar";
         this.BtnFechar.UseVisualStyleBackColor = true;
         this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
         // 
         // groupBox2
         // 
         this.groupBox2.BackColor = System.Drawing.Color.Transparent;
         this.groupBox2.Controls.Add(this.DgvListaRegistros);
         this.groupBox2.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox2.ForeColor = System.Drawing.Color.White;
         this.groupBox2.Location = new System.Drawing.Point(12, 57);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(1013, 184);
         this.groupBox2.TabIndex = 6;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Log";
         // 
         // DgvListaRegistros
         // 
         this.DgvListaRegistros.AllowUserToAddRows = false;
         this.DgvListaRegistros.AllowUserToDeleteRows = false;
         this.DgvListaRegistros.AllowUserToResizeColumns = false;
         this.DgvListaRegistros.AllowUserToResizeRows = false;
         this.DgvListaRegistros.BackgroundColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.DgvListaRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.DgvListaRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.DgvListaRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClTitulo,
            this.ClSprint});
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.DgvListaRegistros.DefaultCellStyle = dataGridViewCellStyle2;
         this.DgvListaRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
         this.DgvListaRegistros.Location = new System.Drawing.Point(3, 21);
         this.DgvListaRegistros.MultiSelect = false;
         this.DgvListaRegistros.Name = "DgvListaRegistros";
         this.DgvListaRegistros.ReadOnly = true;
         this.DgvListaRegistros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.DgvListaRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.DgvListaRegistros.Size = new System.Drawing.Size(1007, 160);
         this.DgvListaRegistros.TabIndex = 0;
         this.DgvListaRegistros.VirtualMode = true;
         this.DgvListaRegistros.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaRegistros_CellEnter);
         // 
         // ClTitulo
         // 
         this.ClTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.ClTitulo.DataPropertyName = "Titulo";
         this.ClTitulo.HeaderText = "Titulo";
         this.ClTitulo.Name = "ClTitulo";
         this.ClTitulo.ReadOnly = true;
         this.ClTitulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
         this.ClTitulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
         // 
         // ClSprint
         // 
         this.ClSprint.DataPropertyName = "Sprint";
         this.ClSprint.FillWeight = 150F;
         this.ClSprint.HeaderText = "Sprint";
         this.ClSprint.MinimumWidth = 150;
         this.ClSprint.Name = "ClSprint";
         this.ClSprint.ReadOnly = true;
         this.ClSprint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
         this.ClSprint.Width = 150;
         // 
         // groupBox1
         // 
         this.groupBox1.BackColor = System.Drawing.Color.Transparent;
         this.groupBox1.Controls.Add(this.TxtDescricao);
         this.groupBox1.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.groupBox1.ForeColor = System.Drawing.Color.White;
         this.groupBox1.Location = new System.Drawing.Point(12, 247);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(1013, 215);
         this.groupBox1.TabIndex = 7;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Descrição";
         // 
         // TxtDescricao
         // 
         this.TxtDescricao.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.TxtDescricao.Location = new System.Drawing.Point(6, 17);
         this.TxtDescricao.Multiline = true;
         this.TxtDescricao.Name = "TxtDescricao";
         this.TxtDescricao.ReadOnly = true;
         this.TxtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.TxtDescricao.Size = new System.Drawing.Size(1001, 192);
         this.TxtDescricao.TabIndex = 0;
         // 
         // FrmEdicao
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
         this.ClientSize = new System.Drawing.Size(1037, 513);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.panel2);
         this.Controls.Add(this.panel1);
         this.ForeColor = System.Drawing.SystemColors.Control;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
         this.Name = "FrmEdicao";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.panel2.ResumeLayout(false);
         this.groupBox2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.DgvListaRegistros)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.Button BtnExcluir;
      private System.Windows.Forms.Button BtnFechar;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.DataGridView DgvListaRegistros;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox TxtDescricao;
      private System.Windows.Forms.DataGridViewTextBoxColumn ClTitulo;
      private System.Windows.Forms.DataGridViewTextBoxColumn ClSprint;
   }
}

