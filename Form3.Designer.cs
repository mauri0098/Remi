
namespace Remi
{
    partial class Form3
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
            this.dptcuadro = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dptcuadro)).BeginInit();
            this.SuspendLayout();
            // 
            // dptcuadro
            // 
            this.dptcuadro.AllowUserToAddRows = false;
            this.dptcuadro.AllowUserToDeleteRows = false;
            this.dptcuadro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dptcuadro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1,
            this.C2});
            this.dptcuadro.Location = new System.Drawing.Point(12, 12);
            this.dptcuadro.Name = "dptcuadro";
            this.dptcuadro.ReadOnly = true;
            this.dptcuadro.Size = new System.Drawing.Size(565, 298);
            this.dptcuadro.TabIndex = 0;
            // 
            // C1
            // 
            this.C1.HeaderText = "NOMBRE";
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            this.C1.Width = 200;
            // 
            // C2
            // 
            this.C2.HeaderText = "TOTALRECAUDADO";
            this.C2.Name = "C2";
            this.C2.ReadOnly = true;
            this.C2.Width = 200;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dptcuadro);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dptcuadro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dptcuadro;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2;
    }
}