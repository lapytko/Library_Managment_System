using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace Library
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private bool CheckInput()
        {
            if ((ISBNBox.Text == "") || (TitleBox.Text == "") || (PubBox.Text == "") || (AuthorBox.Text == "") || (YearBox.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                Book c1 = new Book(ISBNBox.Text, AuthorBox.Text, TitleBox.Text, PubBox.Text, YearBox.Text);
                globals.BookList.Add(c1);
                Book.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
  
        }

        private void ISBNBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '-') || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                return;
            }
            e.Handled = true;
        }

        private void AuthorBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'а') && (e.KeyChar <= 'я') || ((e.KeyChar >= 'А') && (e.KeyChar <= 'Я')) || (e.KeyChar == '.') || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                return;
            }
            e.Handled = true;
        }

        private void TitleBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'а') && (e.KeyChar <= 'я') || ((e.KeyChar >= 'А') && (e.KeyChar <= 'Я')) ||
                (e.KeyChar == '.') || ((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == ' ') ||
                (e.KeyChar == ',') || (e.KeyChar == '!') || (e.KeyChar == '?') || (e.KeyChar == '-') ||
                (e.KeyChar == '.') || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                return;
            }
            e.Handled = true;
        }

    }
}
