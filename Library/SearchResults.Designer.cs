namespace Library
{
    partial class SearchResults
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BookGrid = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Create = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentGrid = new System.Windows.Forms.DataGridView();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GivGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Giv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GivGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
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
            this.BookGrid.Enabled = false;
            this.BookGrid.Location = new System.Drawing.Point(0, 24);
            this.BookGrid.Name = "BookGrid";
            this.BookGrid.Size = new System.Drawing.Size(874, 426);
            this.BookGrid.TabIndex = 3;
            this.BookGrid.Visible = false;
            // 
            // ISBN
            // 
            this.ISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.Width = 57;
            // 
            // Author
            // 
            this.Author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Author.HeaderText = "Автор";
            this.Author.Name = "Author";
            this.Author.Width = 62;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Title.HeaderText = "Название";
            this.Title.Name = "Title";
            this.Title.Width = 82;
            // 
            // Pub
            // 
            this.Pub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Pub.HeaderText = "Издаельство";
            this.Pub.Name = "Pub";
            this.Pub.Width = 99;
            // 
            // Year
            // 
            this.Year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Year.HeaderText = "Год издания";
            this.Year.Name = "Year";
            this.Year.Width = 87;
            // 
            // Create
            // 
            this.Create.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Create.HeaderText = "Дата добавления";
            this.Create.Name = "Create";
            this.Create.ReadOnly = true;
            this.Create.Width = 111;
            // 
            // StudentGrid
            // 
            this.StudentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ticket,
            this.FIO,
            this.Bith,
            this.Phone,
            this.Addr});
            this.StudentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentGrid.Enabled = false;
            this.StudentGrid.Location = new System.Drawing.Point(0, 24);
            this.StudentGrid.Name = "StudentGrid";
            this.StudentGrid.Size = new System.Drawing.Size(874, 426);
            this.StudentGrid.TabIndex = 5;
            this.StudentGrid.Visible = false;
            // 
            // Ticket
            // 
            this.Ticket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ticket.HeaderText = "Номер читательского билета";
            this.Ticket.Name = "Ticket";
            this.Ticket.ReadOnly = true;
            this.Ticket.Width = 165;
            // 
            // FIO
            // 
            this.FIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.Width = 59;
            // 
            // Bith
            // 
            this.Bith.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Bith.HeaderText = "Дата рождения";
            this.Bith.Name = "Bith";
            this.Bith.ReadOnly = true;
            this.Bith.Width = 102;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 77;
            // 
            // Addr
            // 
            this.Addr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Addr.HeaderText = "Адрес";
            this.Addr.Name = "Addr";
            this.Addr.ReadOnly = true;
            this.Addr.Width = 63;
            // 
            // GivGrid
            // 
            this.GivGrid.AllowUserToAddRows = false;
            this.GivGrid.AllowUserToDeleteRows = false;
            this.GivGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GivGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.To,
            this.Giv,
            this.ToDate,
            this.Books,
            this.Status});
            this.GivGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GivGrid.Enabled = false;
            this.GivGrid.Location = new System.Drawing.Point(0, 24);
            this.GivGrid.Name = "GivGrid";
            this.GivGrid.ReadOnly = true;
            this.GivGrid.Size = new System.Drawing.Size(874, 426);
            this.GivGrid.TabIndex = 6;
            this.GivGrid.Visible = false;
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
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 66;
            // 
            // SearchResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.GivGrid);
            this.Controls.Add(this.StudentGrid);
            this.Controls.Add(this.BookGrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchResults";
            this.Text = "Результаты поиска";
            this.Load += new System.EventHandler(this.SearchResults_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BookGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GivGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        public System.Windows.Forms.DataGridView BookGrid;
        public System.Windows.Forms.DataGridView StudentGrid;
        public System.Windows.Forms.DataGridView GivGrid;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pub;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year;
        private System.Windows.Forms.DataGridViewTextBoxColumn Create;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bith;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Giv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Books;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}