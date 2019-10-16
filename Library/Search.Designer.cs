namespace Library
{
    partial class Search
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
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioGiv = new System.Windows.Forms.RadioButton();
            this.radioRead = new System.Windows.Forms.RadioButton();
            this.radioBook = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(59, 12);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(205, 20);
            this.SearchBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Найти:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioGiv);
            this.groupBox1.Controls.Add(this.radioRead);
            this.groupBox1.Controls.Add(this.radioBook);
            this.groupBox1.Location = new System.Drawing.Point(59, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 90);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Что ищем?";
            // 
            // radioGiv
            // 
            this.radioGiv.AutoSize = true;
            this.radioGiv.Location = new System.Drawing.Point(6, 65);
            this.radioGiv.Name = "radioGiv";
            this.radioGiv.Size = new System.Drawing.Size(63, 17);
            this.radioGiv.TabIndex = 2;
            this.radioGiv.TabStop = true;
            this.radioGiv.Text = "Выдачи";
            this.radioGiv.UseVisualStyleBackColor = true;
            // 
            // radioRead
            // 
            this.radioRead.AutoSize = true;
            this.radioRead.Location = new System.Drawing.Point(6, 42);
            this.radioRead.Name = "radioRead";
            this.radioRead.Size = new System.Drawing.Size(73, 17);
            this.radioRead.TabIndex = 1;
            this.radioRead.TabStop = true;
            this.radioRead.Text = "Читатели";
            this.radioRead.UseVisualStyleBackColor = true;
            // 
            // radioBook
            // 
            this.radioBook.AutoSize = true;
            this.radioBook.Location = new System.Drawing.Point(6, 19);
            this.radioBook.Name = "radioBook";
            this.radioBook.Size = new System.Drawing.Size(55, 17);
            this.radioBook.TabIndex = 0;
            this.radioBook.TabStop = true;
            this.radioBook.Text = "Книги";
            this.radioBook.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(277, 166);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Поиск";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioGiv;
        private System.Windows.Forms.RadioButton radioRead;
        private System.Windows.Forms.RadioButton radioBook;
        private System.Windows.Forms.Button button1;
    }
}