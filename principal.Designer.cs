
namespace Remi
{
    partial class principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fROM1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fROM1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fROM1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fROM1ToolStripMenuItem
            // 
            this.fROM1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fROM1ToolStripMenuItem1});
            this.fROM1ToolStripMenuItem.Name = "fROM1ToolStripMenuItem";
            this.fROM1ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.fROM1ToolStripMenuItem.Text = "TAREAS";
            this.fROM1ToolStripMenuItem.Click += new System.EventHandler(this.fROM1ToolStripMenuItem_Click);
            // 
            // fROM1ToolStripMenuItem1
            // 
            this.fROM1ToolStripMenuItem1.Name = "fROM1ToolStripMenuItem1";
            this.fROM1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.fROM1ToolStripMenuItem1.Text = "FROM1";
            this.fROM1ToolStripMenuItem1.Click += new System.EventHandler(this.fROM1ToolStripMenuItem1_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "principal";
            this.Text = "principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fROM1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fROM1ToolStripMenuItem1;
    }
}