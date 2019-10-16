namespace Library
{
    partial class AddReader
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
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BithdayBox = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TicketBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddressBox
            // 
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBox.Location = new System.Drawing.Point(74, 88);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(406, 20);
            this.AddressBox.TabIndex = 4;
            this.AddressBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressBox_KeyPress);
            // 
            // NameBox
            // 
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Location = new System.Drawing.Point(304, 12);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(176, 20);
            this.NameBox.TabIndex = 2;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FNameBox_KeyPress);
            // 
            // FNameBox
            // 
            this.FNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FNameBox.Location = new System.Drawing.Point(74, 12);
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(176, 20);
            this.FNameBox.TabIndex = 1;
            this.FNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FNameBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Телефон:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Адрес:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Имя:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Фамилия:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LNameBox
            // 
            this.LNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LNameBox.Location = new System.Drawing.Point(74, 51);
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(176, 20);
            this.LNameBox.TabIndex = 3;
            this.LNameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FNameBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Отчество:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(327, 125);
            this.PhoneBox.Mask = "+375 (99) 000-00-00";
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(153, 20);
            this.PhoneBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Дата рождения:";
            // 
            // BithdayBox
            // 
            this.BithdayBox.Location = new System.Drawing.Point(361, 50);
            this.BithdayBox.Mask = "00/00/0000";
            this.BithdayBox.Name = "BithdayBox";
            this.BithdayBox.Size = new System.Drawing.Size(119, 20);
            this.BithdayBox.TabIndex = 25;
            this.BithdayBox.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Номер читательского билета:";
            // 
            // TicketBox
            // 
            this.TicketBox.Location = new System.Drawing.Point(161, 125);
            this.TicketBox.Mask = "99999";
            this.TicketBox.Name = "TicketBox";
            this.TicketBox.ReadOnly = true;
            this.TicketBox.Size = new System.Drawing.Size(89, 20);
            this.TicketBox.TabIndex = 27;
            // 
            // AddReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(487, 193);
            this.Controls.Add(this.TicketBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BithdayBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.LNameBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.FNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddReader";
            this.Text = "Добавить читателя";
            this.Load += new System.EventHandler(this.AddReader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox AddressBox;
        public System.Windows.Forms.TextBox NameBox;
        public System.Windows.Forms.TextBox FNameBox;
        public System.Windows.Forms.TextBox LNameBox;
        public System.Windows.Forms.MaskedTextBox PhoneBox;
        public System.Windows.Forms.MaskedTextBox BithdayBox;
        public System.Windows.Forms.MaskedTextBox TicketBox;
    }
}