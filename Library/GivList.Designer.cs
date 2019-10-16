using System.Windows.Forms;

namespace Library
{
    partial class GivList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GivList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add = new System.Windows.Forms.ToolStripButton();
            this.Dell = new System.Windows.Forms.ToolStripButton();
            this.Refresh = new System.Windows.Forms.ToolStripButton();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.GivGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GivGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add,
            this.Dell,
            this.Refresh,
            this.Save,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Add
            // 
            this.Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(63, 22);
            this.Add.Text = "Добавить";
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Dell
            // 
            this.Dell.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Dell.Image = ((System.Drawing.Image)(resources.GetObject("Dell.Image")));
            this.Dell.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Dell.Name = "Dell";
            this.Dell.Size = new System.Drawing.Size(55, 22);
            this.Dell.Text = "Удалить";
            this.Dell.Click += new System.EventHandler(this.Dell_Click);
            // 
            // Refresh
            // 
            this.Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.Image")));
            this.Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(65, 22);
            this.Refresh.Text = "Обновить";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(69, 22);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(48, 22);
            this.toolStripButton1.Text = "Сдано!";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(147, 22);
            this.toolStripButton2.Text = "Показать просроченные";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // GivGrid
            // 
            this.GivGrid.AllowUserToAddRows = false;
            this.GivGrid.AllowUserToDeleteRows = false;
            this.GivGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GivGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GivGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.To,
            this.Giv,
            this.ToDate,
            this.Books,
            this.Status});
            this.GivGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GivGrid.Location = new System.Drawing.Point(0, 25);
            this.GivGrid.Name = "GivGrid";
            this.GivGrid.ReadOnly = true;
            this.GivGrid.Size = new System.Drawing.Size(800, 425);
            this.GivGrid.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "№";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // To
            // 
            this.To.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.To.HeaderText = "Кому выдано";
            this.To.Name = "To";
            this.To.ReadOnly = true;
            this.To.Width = 99;
            // 
            // Giv
            // 
            this.Giv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Giv.HeaderText = "Когда";
            this.Giv.Name = "Giv";
            this.Giv.ReadOnly = true;
            this.Giv.Width = 62;
            // 
            // ToDate
            // 
            this.ToDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ToDate.HeaderText = "Истекает";
            this.ToDate.Name = "ToDate";
            this.ToDate.ReadOnly = true;
            this.ToDate.Width = 80;
            // 
            // Books
            // 
            this.Books.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Books.DefaultCellStyle = dataGridViewCellStyle1;
            this.Books.HeaderText = "Список книг";
            this.Books.Name = "Books";
            this.Books.ReadOnly = true;
            this.Books.Width = 95;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // GivList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GivGrid);
            this.Controls.Add(this.toolStrip1);
            this.Name = "GivList";
            this.Text = "Список выдач";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GivList_FormClosing);
            this.Load += new System.EventHandler(this.GivList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GivGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Add;
        private System.Windows.Forms.ToolStripButton Dell;
        private System.Windows.Forms.ToolStripButton Refresh;
        private System.Windows.Forms.ToolStripButton Save;
        public System.Windows.Forms.DataGridView GivGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Books;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}