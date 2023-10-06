
namespace Remi
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lst = new System.Windows.Forms.ListBox();
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.clmFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKilometros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCIONE CHOFER";
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.Location = new System.Drawing.Point(25, 55);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(208, 277);
            this.lst.TabIndex = 1;
            this.lst.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // dgvViajes
            // 
            this.dgvViajes.AllowUserToAddRows = false;
            this.dgvViajes.AllowUserToDeleteRows = false;
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFecha,
            this.clmDesde,
            this.clmHasta,
            this.clmKilometros,
            this.clmImporte});
            this.dgvViajes.Location = new System.Drawing.Point(265, 12);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.ReadOnly = true;
            this.dgvViajes.Size = new System.Drawing.Size(543, 394);
            this.dgvViajes.TabIndex = 6;
            // 
            // clmFecha
            // 
            this.clmFecha.HeaderText = "Fecha";
            this.clmFecha.Name = "clmFecha";
            this.clmFecha.ReadOnly = true;
            // 
            // clmDesde
            // 
            this.clmDesde.HeaderText = "Desde";
            this.clmDesde.Name = "clmDesde";
            this.clmDesde.ReadOnly = true;
            // 
            // clmHasta
            // 
            this.clmHasta.HeaderText = "Hasta";
            this.clmHasta.Name = "clmHasta";
            this.clmHasta.ReadOnly = true;
            // 
            // clmKilometros
            // 
            this.clmKilometros.HeaderText = "Kilometros";
            this.clmKilometros.Name = "clmKilometros";
            this.clmKilometros.ReadOnly = true;
            // 
            // clmImporte
            // 
            this.clmImporte.HeaderText = "Importe";
            this.clmImporte.Name = "clmImporte";
            this.clmImporte.ReadOnly = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 438);
            this.Controls.Add(this.dgvViajes);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKilometros;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmImporte;
    }
}