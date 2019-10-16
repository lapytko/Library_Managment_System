using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AddReader : Form
    {
        public AddReader()
        {
            InitializeComponent();
        }

        private bool CheckInput()
        {
            if ((FNameBox.Text == "") || (NameBox.Text == "") || (LNameBox.Text == "") || (BithdayBox.Text == "") || (PhoneBox.Text == "") || (AddressBox.Text == "") || (TicketBox.Text == ""))
            {
                return false;
            }
            else return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                Student c1 = new Student(TicketBox.Text, FNameBox.Text, NameBox.Text, LNameBox.Text, BithdayBox.Text, PhoneBox.Text, AddressBox.Text);
                globals.StudentList.Add(c1);
                Student.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

        }

        private void AddReader_Load(object sender, EventArgs e)
        {
            TicketBox.Text = GenNumber();
        }

        private string GenNumber()
        {
            Random r = new Random();
            string num = "";
            do
            {
                int k = r.Next(0, 9);
                num += k.ToString();
            }
            while (num.Length <= 5);
            return num;
        }

        private void FNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'а') && (e.KeyChar <= 'я') || ((e.KeyChar >= 'А') && (e.KeyChar <= 'Я')) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                return;
            }
            e.Handled = true;
        }

        private void AddressBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'а') && (e.KeyChar <= 'я') || ((e.KeyChar >= 'А') && (e.KeyChar <= 'Я')) ||
               (e.KeyChar == '.') || ((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == ' ') ||
               (e.KeyChar == ',') ||(e.KeyChar == '/') || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                return;
            }
            e.Handled = true;
        }
    }
}
