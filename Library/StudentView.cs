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
    public partial class StudentView : Form
    {
        public StudentView()
        {
            InitializeComponent();
        }
        private void StudentView_Load(object sender, EventArgs e)
        {
            Student.Load();
            Print();
        }

        /// <summary>
        /// Обновить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            StudentGrid.Rows.Clear();
            Print();
        }

        /// <summary>
        /// Вывод данных в таблицу
        /// </summary>
        private void Print()
        {
            StudentGrid.Rows.Clear();
            foreach (Student o in globals.StudentList)
            {
                int n = StudentGrid.Rows.Add();
                StudentGrid.Rows[n].Cells["Ticket"].Value = o.ticket;
                StudentGrid.Rows[n].Cells["FIO"].Value = o.fname + " " + o.name + " " + o.lname;
                StudentGrid.Rows[n].Cells["Bith"].Value = o.bith.ToShortDateString();
                StudentGrid.Rows[n].Cells["Phone"].Value = o.phone;
                StudentGrid.Rows[n].Cells["Addr"].Value = o.adress;
            }
        }

        /// <summary>
        /// Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Student.Save();
        }

        /// <summary>
        /// добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            AddReader addReader = new AddReader();
            addReader.MdiParent = this.MdiParent;
            addReader.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            int n = StudentGrid.SelectedCells[0].RowIndex;
            globals.StudentList.RemoveAt(n);
            System.IO.File.Delete(@"../../Students.xml");
            Book.Save();
            Print();
        }

        private void поНомеруБилетаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globals.StudentList.Sort(new TicketComparer());
            StudentGrid.Rows.Clear();
            Print();
        }

        private void поФИОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globals.StudentList.Sort(new FIOComparer());
            StudentGrid.Rows.Clear();
            Print();
        }

        private void поДатеРожденияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globals.StudentList.Sort(new BithComparer());
            StudentGrid.Rows.Clear();
            Print();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            int n = StudentGrid.SelectedCells[0].RowIndex;
            EditReader Edit = new EditReader();
            Edit.MdiParent = this.MdiParent;
            Edit.TicketBox.Text = globals.StudentList[n].ticket;
            Edit.FNameBox.Text = globals.StudentList[n].fname;
            Edit.NameBox.Text = globals.StudentList[n].name;
            Edit.LNameBox.Text = globals.StudentList[n].lname;
            Edit.BithdayBox.Text = globals.StudentList[n].bith.ToShortDateString();
            Edit.PhoneBox.Text = globals.StudentList[n].phone;
            Edit.AddressBox.Text = globals.StudentList[n].adress;
            Edit.Show();
        }
    }
}
