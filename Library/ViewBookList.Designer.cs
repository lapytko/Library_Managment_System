using System.Windows.Forms;

namespace Library
{
    partial class ViewBookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBookList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Add = new System.Windows.Forms.ToolStripButton();
            this.Dell = new System.Windows.Forms.ToolStripButton();
            this.SortBy = new System.Windows.Forms.ToolStripDropDownButton();
            this.поНазваниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поАвторуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИздательствуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеДобавленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Refresh = new System.Windows.Forms.ToolStripButton();
            this.Save = new System.Windows.Forms.ToolStripButton();
            this.Edit = new System.Windows.Forms.ToolStripButton();
            this.BookGrid = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Create = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add,
            this.Dell,
            this.SortBy,
            this.Refresh,
            this.Save,
            this.Edit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(849, 25);
            this.toolStrip1.TabIndex = 1;
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
            this.Add.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // Dell
            // 
            this.Dell.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Dell.Image = ((System.Drawing.Image)(resources.GetObject("Dell.Image")));
            this.Dell.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Dell.Name = "Dell";
            this.Dell.Size = new System.Drawing.Size(55, 22);
            this.Dell.Text = "Удалить";
            this.Dell.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // SortBy
            // 
            this.SortBy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SortBy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНазваниюToolStripMenuItem,
            this.поАвторуToolStripMenuItem,
            this.поИздательствуToolStripMenuItem,
            this.поДатеДобавленияToolStripMenuItem});
            this.SortBy.Image = ((System.Drawing.Image)(resources.GetObject("SortBy.Image")));
            this.SortBy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortBy.Name = "SortBy";
            this.SortBy.Size = new System.Drawing.Size(91, 22);
            this.SortBy.Text = "Сортировать";
            // 
            // поНазваниюToolStripMenuItem
            // 
            this.поНазваниюToolStripMenuItem.Name = "поНазваниюToolStripMenuItem";
            this.поНазваниюToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.поНазваниюToolStripMenuItem.Text = "По названию";
            this.поНазваниюToolStripMenuItem.Click += new System.EventHandler(this.поНазваниюToolStripMenuItem_Click);
            // 
            // поАвторуToolStripMenuItem
            // 
            this.поАвторуToolStripMenuItem.Name = "поАвторуToolStripMenuItem";
            this.поАвторуToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.поАвторуToolStripMenuItem.Text = "По автору";
            this.поАвторуToolStripMenuItem.Click += new System.EventHandler(this.поАвторуToolStripMenuItem_Click);
            // 
            // поИздательствуToolStripMenuItem
            // 
            this.поИздательствуToolStripMenuItem.Name = "поИздательствуToolStripMenuItem";
            this.поИздательствуToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.поИздательствуToolStripMenuItem.Text = "По издательству";
            this.поИздательствуToolStripMenuItem.Click += new System.EventHandler(this.поИздательствуToolStripMenuItem_Click);
            // 
            // поДатеДобавленияToolStripMenuItem
            // 
            this.поДатеДобавленияToolStripMenuItem.Name = "поДатеДобавленияToolStripMenuItem";
            this.поДатеДобавленияToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.поДатеДобавленияToolStripMenuItem.Text = "По дате добавления";
            this.поДатеДобавленияToolStripMenuItem.Click += new System.EventHandler(this.поДатеДобавленияToolStripMenuItem_Click);
            // 
            // Refresh
            // 
            this.Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.Image")));
            this.Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(65, 22);
            this.Refresh.Text = "Обновить";
            this.Refresh.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Save
            // 
            this.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(69, 22);
            this.Save.Text = "Сохранить";
            this.Save.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // Edit
            // 
            this.Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(86, 22);
            this.Edit.Text = "Редакировать";
            this.Edit.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // BookGrid
            // 
            this.BookGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.Author,
            this.Title,
            this.Pub,
            this.Year,
            this.Create});
            this.BookGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BookGrid.Location = new System.Drawing.Point(0, 25);
            this.BookGrid.Name = "BookGrid";
            this.BookGrid.Size = new System.Drawing.Size(849, 425);
            this.BookGrid.TabIndex = 2;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 110;
            // 
            // Author
            // 
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            this.Author.Width = 140;
            // 
            // Title
            // 
            this.Title.HeaderText = "Название";
            this.Title.Name = "Title";
            this.Title.Width = 250;
            // 
            // Pub
            // 
            this.Pub.HeaderText = "Издаельство";
            this.Pub.Name = "Pub";
            // 
            // Year
            // 
            this.Year.HeaderText = "Год издания";
            this.Year.Name = "Year";
            // 
            // Create
            // 
            this.Create.HeaderText = "Дата добавления";
            this.Create.Name = "Create";
            this.Create.ReadOnly = true;
            // 
            // ViewBookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 450);
            this.Controls.Add(this.BookGrid);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewBookList";
            this.Text = "Список книг";
            this.Load += new System.EventHandler(this.ViewBookList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Dell;
        private System.Windows.Forms.ToolStripButton Refresh;
        private System.Windows.Forms.ToolStripButton Add;
        public System.Windows.Forms.DataGridView BookGrid;
        private System.Windows.Forms.ToolStripButton Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Create;
        private System.Windows.Forms.ToolStripDropDownButton SortBy;
        private System.Windows.Forms.ToolStripMenuItem поНазваниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поАвторуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИздательствуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДатеДобавленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton Edit;

    }
}