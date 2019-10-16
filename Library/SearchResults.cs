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
    public partial class SearchResults : Form
    {
        public SearchResults()
        {
            InitializeComponent();
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.Filter = "XML files|*.xml";
            saveFileDialog1.FileName = "Search_" + DateTime.Now.ToShortDateString();
        }

        private void SearchResults_Load(object sender, EventArgs e)
        {
            if (globals.SearchFlag == 1)
            {
                BookGrid.Enabled = true;
                BookGrid.Visible = true;
                BookPrint();
            }
            if (globals.SearchFlag == 2)
            {
                StudentGrid.Enabled = true;
                StudentGrid.Visible = true;
                StudentPrint();
            }
            if (globals.SearchFlag == 3)
            {
                GivGrid.Enabled = true;
                GivGrid.Visible = true;
                GivPrint();
            }
            if (globals.SearchFlag == 4)
            {
                GivGrid.Enabled = true;
                GivGrid.Visible = true;
                GivPrint();


            }
        }

        private void BookPrint()
        {
            BookGrid.Rows.Clear();
            for (int i = 0; i < globals.Search.Length; i++)
            {
                Book o = globals.BookList[globals.Search[i]];
                int n = BookGrid.Rows.Add();
                BookGrid.Rows[n].Cells["ISBN"].Value = o.isbn;
                BookGrid.Rows[n].Cells["Author"].Value = o.author;
                BookGrid.Rows[n].Cells["Title"].Value = o.title;
                BookGrid.Rows[n].Cells["Pub"].Value = o.publish;
                BookGrid.Rows[n].Cells["Year"].Value = o.year;
                BookGrid.Rows[n].Cells["Create"].Value = o.create;
            }
            foreach (DataGridViewRow row in BookGrid.Rows)
            {
                this.Height = (menuStrip1.Height + (BookGrid.Rows.Count * row.Height)) * BookGrid.Rows.Count;
            }
            foreach (DataGridViewColumn col in BookGrid.Columns)
            {
                this.Width = 50;
                this.Width += col.Width * (BookGrid.Columns.Count + 2);
            }

        }
        private void StudentPrint()
        {
            StudentGrid.Rows.Clear();
            for (int i = 0; i < globals.Search.Length; i++)
            {
                Student o = globals.StudentList[globals.Search[i]];
                int n = StudentGrid.Rows.Add();
                StudentGrid.Rows[n].Cells["Ticket"].Value = o.ticket;
                StudentGrid.Rows[n].Cells["FIO"].Value = o.fname + " " + o.name + " " + o.lname;
                StudentGrid.Rows[n].Cells["Bith"].Value = o.bith.ToShortDateString();
                StudentGrid.Rows[n].Cells["Phone"].Value = o.phone;
                StudentGrid.Rows[n].Cells["Addr"].Value = o.adress;
            }
            foreach (DataGridViewRow row in StudentGrid.Rows)
            {
                this.Height = (menuStrip1.Height + (StudentGrid.Rows.Count * row.Height)) * (StudentGrid.Rows.Count+1);
            }
            foreach (DataGridViewColumn col in StudentGrid.Columns)
            {
                this.Width = 20;
                this.Width += col.Width * ((2*StudentGrid.Columns.Count) + 2);
            }
        }
        private void GivPrint()
        {
            GivGrid.Rows.Clear();
            for (int i = 0; i < globals.Search.Length; i++)
            {
                Giving o = globals.GivtList[globals.Search[i]];
                int n = GivGrid.Rows.Add();
                GivGrid.Rows[n].Cells["ID"].Value = o.id;
                GivGrid.Rows[n].Cells["To"].Value = Reader_Search(o.reader);
                GivGrid.Rows[n].Cells["Giv"].Value = o.create.ToShortDateString();
                GivGrid.Rows[n].Cells["ToDate"].Value = o.expirie.ToShortDateString();
                GivGrid.Rows[n].Cells["Books"].Value = o.ToString();
                GivGrid.Rows[n].Cells["Status"].Value = CheckStatus(o);
                GivGrid.Rows[n].Height = o.books.Length * 40;
            }
            foreach (DataGridViewRow row in GivGrid.Rows)
            {
                this.Height = menuStrip1.Height + (GivGrid.Rows.Count * (row.Height * 3));
            }
            foreach (DataGridViewColumn col in StudentGrid.Columns)
            {
                this.Width = 20;
                this.Width += col.Width * (GivGrid.Columns.Count + 1);
            }
        }
        private string Reader_Search(string ticket)
        {
            int n = 0;
            foreach (Student o in globals.StudentList)
            {
                if (o.ticket == ticket)
                {
                    n = globals.StudentList.IndexOf(o);
                    break;
                }
            }
            return globals.StudentList[n].fname + " " + globals.StudentList[n].name + " " + globals.StudentList[n].lname;
        }
        public string CheckStatus(Giving o)
        {
            if (o.status == false) { return "Открыта"; }
            else { return "Закрыта"; }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            switch (globals.SearchFlag)
            {
                case 0:
                    MessageBox.Show("Введите запрос для поиска");
                    return;
                case 1:
                    Book.SaveRes(filename, globals.Search);
                    break;
                case 2:
                    Student.SaveRes(filename, globals.Search);
                    break;
                case 3:
                    Giving.SaveRes(filename, globals.Search);
                    break;
                case 4:
                    Giving.SaveRes(filename, globals.Search);
                    break;
            }
            MessageBox.Show("Файл сохранен");
        }
    }
}
