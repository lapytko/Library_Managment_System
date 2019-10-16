namespace Library
{
    partial class StudentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentView));
            this.StudentGrid = new System.Windows.Forms.DataGridView();
            this.Ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bith = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.поНомеруБилетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеРожденияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.StudentGrid.Location = new System.Drawing.Point(0, 25);
            this.StudentGrid.Name = "StudentGrid";
            this.StudentGrid.Size = new System.Drawing.Size(922, 403);
            this.StudentGrid.TabIndex = 4;
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(922, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton4.Text = "Добавить";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton2.Text = "Удалить";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНомеруБилетаToolStripMenuItem,
            this.поФИОToolStripMenuItem,
            this.поДатеРожденияToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(91, 22);
            this.toolStripButton1.Text = "Сортировать";
            // 
            // поНомеруБилетаToolStripMenuItem
            // 
            this.поНомеруБилетаToolStripMenuItem.Name = "поНомеруБилетаToolStripMenuItem";
            this.поНомеруБилетаToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.поНомеруБилетаToolStripMenuItem.Text = "По номеру билета";
            this.поНомеруБилетаToolStripMenuItem.Click += new System.EventHandler(this.поНомеруБилетаToolStripMenuItem_Click);
            // 
            // поФИОToolStripMenuItem
            // 
            this.поФИОToolStripMenuItem.Name = "поФИОToolStripMenuItem";
            this.поФИОToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.поФИОToolStripMenuItem.Text = "По ФИО";
            this.поФИОToolStripMenuItem.Click += new System.EventHandler(this.поФИОToolStripMenuItem_Click);
            // 
            // поДатеРожденияToolStripMenuItem
            // 
            this.поДатеРожденияToolStripMenuItem.Name = "поДатеРожденияToolStripMenuItem";
            this.поДатеРожденияToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.поДатеРожденияToolStripMenuItem.Text = "По дате рождения";
            this.поДатеРожденияToolStripMenuItem.Click += new System.EventHandler(this.поДатеРожденияToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton3.Text = "Обновить";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(69, 22);
            this.toolStripButton5.Text = "Сохранить";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(91, 22);
            this.toolStripButton6.Text = "Редактировать";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 428);
            this.Controls.Add(this.StudentGrid);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentView";
            this.Text = "Список читателей";
            this.Load += new System.EventHandler(this.StudentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView StudentGrid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem поНомеруБилетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФИОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДатеРожденияToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bith;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addr;
    }
}