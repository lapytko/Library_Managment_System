namespace Library
{
    partial class EditBook
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
            this.button1 = new System.Windows.Forms.Button();
            this.YearBox = new System.Windows.Forms.TextBox();
            this.PubBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.AuthorBox = new System.Windows.Forms.TextBox();
            this.ISBNBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // YearBox
            // 
            this.YearBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YearBox.Location = new System.Drawing.Point(93, 163);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(103, 20);
            this.YearBox.TabIndex = 19;
            // 
            // PubBox
            // 
            this.PubBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PubBox.Location = new System.Drawing.Point(93, 125);
            this.PubBox.Name = "PubBox";
            this.PubBox.Size = new System.Drawing.Size(200, 20);
            this.PubBox.TabIndex = 18;
            // 
            // TitleBox
            // 
            this.TitleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleBox.Location = new System.Drawing.Point(93, 85);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(200, 20);
            this.TitleBox.TabIndex = 17;
            // 
            // AuthorBox
            // 
            this.AuthorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AuthorBox.Location = new System.Drawing.Point(93, 49);
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.Size = new System.Drawing.Size(200, 20);
            this.AuthorBox.TabIndex = 16;
            // 
            // ISBNBox
            // 
            this.ISBNBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ISBNBox.Location = new System.Drawing.Point(93, 12);
            this.ISBNBox.Name = "ISBNBox";
            this.ISBNBox.ReadOnly = true;
            this.ISBNBox.Size = new System.Drawing.Size(200, 20);
            this.ISBNBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Год издания:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Издательство:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Название:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Автор:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ISBN:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 248);
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
            this.Name = "EditBook";
            this.Text = "Изменить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox YearBox;
        public System.Windows.Forms.TextBox PubBox;
        public System.Windows.Forms.TextBox TitleBox;
        public System.Windows.Forms.TextBox AuthorBox;
        public System.Windows.Forms.TextBox ISBNBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}