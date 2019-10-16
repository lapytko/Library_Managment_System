namespace Library
{
    partial class AddGiv
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
            this.TicketBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.givBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.getBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BookBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBook = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TicketBox
            // 
            this.TicketBox.Location = new System.Drawing.Point(168, 12);
            this.TicketBox.Mask = "99999";
            this.TicketBox.Name = "TicketBox";
            this.TicketBox.Size = new System.Drawing.Size(239, 20);
            this.TicketBox.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Номер читательского билета:";
            // 
            // givBox
            // 
            this.givBox.Location = new System.Drawing.Point(168, 38);
            this.givBox.Mask = "00/00/0000";
            this.givBox.Name = "givBox";
            this.givBox.ReadOnly = true;
            this.givBox.Size = new System.Drawing.Size(239, 20);
            this.givBox.TabIndex = 31;
            this.givBox.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Дата выдачи:";
            // 
            // getBox
            // 
            this.getBox.Location = new System.Drawing.Point(168, 64);
            this.getBox.Mask = "00/00/0000";
            this.getBox.Name = "getBox";
            this.getBox.Size = new System.Drawing.Size(239, 20);
            this.getBox.TabIndex = 33;
            this.getBox.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Дата окончания:";
            // 
            // BookBox
            // 
            this.BookBox.FormattingEnabled = true;
            this.BookBox.Location = new System.Drawing.Point(168, 90);
            this.BookBox.MaxLength = 10;
            this.BookBox.Name = "BookBox";
            this.BookBox.Size = new System.Drawing.Size(239, 21);
            this.BookBox.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Книги:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBook
            // 
            this.listBook.FormattingEnabled = true;
            this.listBook.Location = new System.Drawing.Point(168, 119);
            this.listBook.Name = "listBook";
            this.listBook.Size = new System.Drawing.Size(239, 108);
            this.listBook.TabIndex = 37;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 38;
            this.button2.Text = "Создать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddGiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(499, 277);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBook);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookBox);
            this.Controls.Add(this.getBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.givBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TicketBox);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGiv";
            this.Text = "Создание выдачи";
            this.Load += new System.EventHandler(this.AddGiv_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox TicketBox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox givBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox getBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox BookBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBook;
        private System.Windows.Forms.Button button2;
    }
}