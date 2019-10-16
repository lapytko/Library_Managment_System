namespace Library
{
    partial class EditReader
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
            this.BithdayBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PhoneBox = new System.Windows.Forms.MaskedTextBox();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TicketBox
            // 
            this.TicketBox.Location = new System.Drawing.Point(165, 12);
            this.TicketBox.Mask = "99999";
            this.TicketBox.Name = "TicketBox";
            this.TicketBox.ReadOnly = true;
            this.TicketBox.Size = new System.Drawing.Size(176, 20);
            this.TicketBox.TabIndex = 43;
            this.TicketBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Номер читательского билета:";
            // 
            // BithdayBox
            // 
            this.BithdayBox.Location = new System.Drawing.Point(165, 119);
            this.BithdayBox.Mask = "00/00/0000";
            this.BithdayBox.Name = "BithdayBox";
            this.BithdayBox.Size = new System.Drawing.Size(176, 20);
            this.BithdayBox.TabIndex = 41;
            this.BithdayBox.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Дата рождения:";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(165, 145);
            this.PhoneBox.Mask = "+375 (99) 000-00-00";
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(176, 20);
            this.PhoneBox.TabIndex = 39;
            // 
            // LNameBox
            // 
            this.LNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LNameBox.Location = new System.Drawing.Point(165, 93);
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(176, 20);
            this.LNameBox.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Отчество:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddressBox
            // 
            this.AddressBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressBox.Location = new System.Drawing.Point(52, 171);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(407, 20);
            this.AddressBox.TabIndex = 31;
            // 
            // NameBox
            // 
            this.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameBox.Location = new System.Drawing.Point(165, 67);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(176, 20);
            this.NameBox.TabIndex = 29;
            // 
            // FNameBox
            // 
            this.FNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FNameBox.Location = new System.Drawing.Point(165, 41);
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FNameBox.Size = new System.Drawing.Size(176, 20);
            this.FNameBox.TabIndex = 28;
            this.FNameBox.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Телефон:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Адрес:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Имя:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Фамилия:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EditReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(464, 225);
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
            this.Name = "EditReader";
            this.Text = "Изменить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox TicketBox;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.MaskedTextBox BithdayBox;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox PhoneBox;
        public System.Windows.Forms.TextBox LNameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox AddressBox;
        public System.Windows.Forms.TextBox NameBox;
        public System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}