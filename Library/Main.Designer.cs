namespace Library
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.книгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовогоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьСписокЧитателейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выдачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВыдачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьВыдачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.книгиToolStripMenuItem,
            this.читательToolStripMenuItem,
            this.выдачиToolStripMenuItem,
            this.поискToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // книгиToolStripMenuItem
            // 
            this.книгиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНовуюToolStripMenuItem,
            this.посмотретьКнигиToolStripMenuItem});
            this.книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            this.книгиToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.книгиToolStripMenuItem.Text = "Книги";
            // 
            // добавитьНовуюToolStripMenuItem
            // 
            this.добавитьНовуюToolStripMenuItem.Name = "добавитьНовуюToolStripMenuItem";
            this.добавитьНовуюToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.добавитьНовуюToolStripMenuItem.Text = "Добавить новую";
            this.добавитьНовуюToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовуюToolStripMenuItem_Click);
            // 
            // посмотретьКнигиToolStripMenuItem
            // 
            this.посмотретьКнигиToolStripMenuItem.Name = "посмотретьКнигиToolStripMenuItem";
            this.посмотретьКнигиToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.посмотретьКнигиToolStripMenuItem.Text = "Посмотреть книги";
            this.посмотретьКнигиToolStripMenuItem.Click += new System.EventHandler(this.посмотретьКнигиToolStripMenuItem_Click);
            // 
            // читательToolStripMenuItem
            // 
            this.читательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНовогоToolStripMenuItem,
            this.просмотретьСписокЧитателейToolStripMenuItem});
            this.читательToolStripMenuItem.Name = "читательToolStripMenuItem";
            this.читательToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.читательToolStripMenuItem.Text = "Читатель";
            // 
            // добавитьНовогоToolStripMenuItem
            // 
            this.добавитьНовогоToolStripMenuItem.Name = "добавитьНовогоToolStripMenuItem";
            this.добавитьНовогоToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.добавитьНовогоToolStripMenuItem.Text = "Добавить нового ";
            this.добавитьНовогоToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовогоToolStripMenuItem_Click);
            // 
            // просмотретьСписокЧитателейToolStripMenuItem
            // 
            this.просмотретьСписокЧитателейToolStripMenuItem.Name = "просмотретьСписокЧитателейToolStripMenuItem";
            this.просмотретьСписокЧитателейToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.просмотретьСписокЧитателейToolStripMenuItem.Text = "Просмотреть список читателей";
            this.просмотретьСписокЧитателейToolStripMenuItem.Click += new System.EventHandler(this.просмотретьСписокЧитателейToolStripMenuItem_Click);
            // 
            // выдачиToolStripMenuItem
            // 
            this.выдачиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокВыдачToolStripMenuItem,
            this.создатьВыдачуToolStripMenuItem});
            this.выдачиToolStripMenuItem.Name = "выдачиToolStripMenuItem";
            this.выдачиToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.выдачиToolStripMenuItem.Text = "Выдачи";
            // 
            // списокВыдачToolStripMenuItem
            // 
            this.списокВыдачToolStripMenuItem.Name = "списокВыдачToolStripMenuItem";
            this.списокВыдачToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.списокВыдачToolStripMenuItem.Text = "Просмотреть список выдач";
            this.списокВыдачToolStripMenuItem.Click += new System.EventHandler(this.списокВыдачToolStripMenuItem_Click);
            // 
            // создатьВыдачуToolStripMenuItem
            // 
            this.создатьВыдачуToolStripMenuItem.Name = "создатьВыдачуToolStripMenuItem";
            this.создатьВыдачуToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.создатьВыдачуToolStripMenuItem.Text = "Создать выдачу";
            this.создатьВыдачуToolStripMenuItem.Click += new System.EventHandler(this.создатьВыдачуToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Библиотека";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem книгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовуюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьКнигиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem читательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовогоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьСписокЧитателейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выдачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокВыдачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьВыдачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
    }
}

