using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class EditReader : Form
    {
        public EditReader()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            foreach (Student o in globals.StudentList)
            {
                if (o.ticket == TicketBox.Text) { k = globals.StudentList.IndexOf(o); }
            }
            Student Editable = globals.StudentList[k];
            Editable.lname = LNameBox.Text;
            Editable.name = NameBox.Text;
            Editable.fname = FNameBox.Text;
            Editable.phone = PhoneBox.Text;
            Editable.adress = AddressBox.Text;
            Editable.bith = Student.ToDateTime(BithdayBox.Text);
            Student.Save();
            this.Close();
        }
    }
}
