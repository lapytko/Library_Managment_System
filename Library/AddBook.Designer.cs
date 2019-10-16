namespace Library
{
    partial class AddBook
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ISBNBox = new System.Windows.Forms.TextBox();
            this.AuthorBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.PubBox = new System.Windows.Forms.TextBox();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Автор:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Название:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Издательство:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Год издания:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ISBNBox
            // 
            this.ISBNBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ISBNBox.Location = new System.Drawing.Point(100, 9);
            this.ISBNBox.Name = "ISBNBox";
            this.ISBNBox.Size = new System.Drawing.Size(200, 20);
            this.ISBNBox.TabIndex = 1;
            this.ISBNBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ISBNBox_KeyPress);
            // 
            // AuthorBox
            // 
            this.AuthorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AuthorBox.Location = new System.Drawing.Point(100, 46);
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.Size = new System.Drawing.Size(200, 20);
            this.AuthorBox.TabIndex = 5;
            this.AuthorBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TitleBox_KeyPress);
            // 
            // TitleBox
            // 
            this.TitleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBox.Location = new System.Drawing.Point(100, 82);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(200, 20);
            this.TitleBox.TabIndex = 6;
            this.TitleBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TitleBox_KeyPress);
            // 
            // PubBox
            // 
            this.PubBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PubBox.Location = new System.Drawing.Point(100, 122);
            this.PubBox.Name = "PubBox";
            this.PubBox.Size = new System.Drawing.Size(200, 20);
            this.PubBox.TabIndex = 7;
            this.PubBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AuthorBox_KeyPress);
            // 
            // YearBox
            // 
            this.YearBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YearBox.Location = new System.Drawing.Point(100, 160);
            this.YearBox.MaxLength = 4;
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(103, 20);
            this.YearBox.TabIndex = 8;
            this.YearBox.Tag = "";
            this.YearBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ISBNBox_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 242);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.PubBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.AuthorBox);
            this.Controls.Add(this.ISBNBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBook";
            this.ShowIcon = false;
            this.Text = "Добаить новую книгу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox ISBNBox;
        public System.Windows.Forms.TextBox AuthorBox;
        public System.Windows.Forms.TextBox TitleBox;
        public System.Windows.Forms.TextBox PubBox;
        public System.Windows.Forms.TextBox YearBox;
    }
}