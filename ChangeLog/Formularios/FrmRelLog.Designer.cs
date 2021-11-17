namespace Formularios
{
   partial class FrmRelLog
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
         this.components = new System.ComponentModel.Container();
         Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
         this.label1 = new System.Windows.Forms.Label();
         this.panel1 = new System.Windows.Forms.Panel();
         this.RVLog = new Microsoft.Reporting.WinForms.ReportViewer();
         this.LogDTSBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.LogDTSBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Gadugi", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(10, 7);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(135, 32);
         this.label1.TabIndex = 0;
         this.label1.Text = "Relatório";
         // 
         // panel1
         // 
         this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
         this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.panel1.Controls.Add(this.label1);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(860, 51);
         this.panel1.TabIndex = 1;
         // 
         // RVLog
         // 
         this.RVLog.Dock = System.Windows.Forms.DockStyle.Fill;
         reportDataSource1.Name = "DataSetLog";
         reportDataSource1.Value = this.LogDTSBindingSource;
         this.RVLog.LocalReport.DataSources.Add(reportDataSource1);
         this.RVLog.LocalReport.ReportEmbeddedResource = "ChangeLog.Relatorios.RelLog.rdlc";
         this.RVLog.Location = new System.Drawing.Point(0, 51);
         this.RVLog.Name = "RVLog";
         this.RVLog.Size = new System.Drawing.Size(860, 489);
         this.RVLog.TabIndex = 2;
         // 
         // LogDTSBindingSource
         // 
         this.LogDTSBindingSource.DataSource = typeof(ChangeLog.Entidades.RDLC.LogDTS);
         // 
         // FrmRelLog
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
         this.ClientSize = new System.Drawing.Size(860, 540);
         this.Controls.Add(this.RVLog);
         this.Controls.Add(this.panel1);
         this.ForeColor = System.Drawing.SystemColors.Control;
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
         this.Name = "FrmRelLog";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Load += new System.EventHandler(this.FrmRelLog_Load);
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.LogDTSBindingSource)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Panel panel1;
      private Microsoft.Reporting.WinForms.ReportViewer RVLog;
      private System.Windows.Forms.BindingSource LogDTSBindingSource;
   }
}

