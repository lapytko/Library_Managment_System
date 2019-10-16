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
    public partial class GivList : Form
    {
        SearchResults results = null;
        public GivList()
        {
            InitializeComponent();
        }

        private void GivList_Load(object sender, EventArgs e)
        {
            if (globals.GivtList.Count == 0)
            {
                MessageBox.Show(this, "Выдач нет", ":(", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            else
            {
                Print();
            }

        }

        public string Reader_Search(string ticket)
        {
            if (globals.GivtList.Count > 0)
            {
                int n = 0;
                foreach (Student o in globals.StudentList)
                {
                    if (o.ticket == ticket)
                    {
                        n = globals.StudentList.IndexOf(o);

                    }
                }
                return globals.StudentList[n].fname + " " + globals.StudentList[n].name + " " + globals.StudentList[n].lname;
            }
            else
            {
                MessageBox.Show(this, "Добавте читателей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return " ";
            }
        }

        public string CheckStatus(Giving o)
        {
            if (o.status == false) { return "Открыта"; }
            else { return "Закрыта"; }
        }

        public void Print()
        {
            GivGrid.Rows.Clear();
            foreach (Giving o in globals.GivtList)
            {
                int n = GivGrid.Rows.Add();

                GivGrid.Rows[n].Cells["ID"].Value = o.id;
                GivGrid.Rows[n].Cells["To"].Value = Reader_Search(o.reader);
                GivGrid.Rows[n].Cells["Giv"].Value = o.create.ToShortDateString();
                GivGrid.Rows[n].Cells["ToDate"].Value = o.expirie.ToShortDateString();
                GivGrid.Rows[n].Cells["Books"].Value = o.ToString();
                GivGrid.Rows[n].Cells["Status"].Value = CheckStatus(o);
                GivGrid.Rows[n].Height = o.books.Length * 40;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddGiv addgiv = new AddGiv();
            addgiv.MdiParent = this.MdiParent;
            addgiv.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int k = 0;
            int n = GivGrid.SelectedCells[0].RowIndex;
            foreach (Giving o in globals.GivtList)
            {
                string s = GivGrid.Rows[n].Cells["ID"].Value.ToString();
                if (o.id == s) { k = globals.GivtList.IndexOf(o); }
            }
            globals.GivtList[k].status = true;
            System.IO.File.Delete(@"Givs.xml");
            Giving.Save();
            GivGrid.Rows.Clear();
            Print();
        }

        private void GivList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Giving.Save();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            globals.SearchFlag = 4;
            if (results == null)
            {
                globals.Search = Giving.SearchExp(DateTime.Now.ToShortDateString());
                if (globals.Search.Length>0)
                {
                    globals.isGood = true;
                    results = new SearchResults();
                    results.MdiParent = this.MdiParent;
                    results.FormClosed += Results_FormClosed;
                    results.Show();
                }
                else
                {
                    MessageBox.Show(this, "Просроченных книг нет", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
            }


        }

        private void Results_FormClosed(object sender, FormClosedEventArgs e)
        {
            results = null;
        }

        private void Dell_Click(object sender, EventArgs e)
        {
            int n = GivGrid.SelectedCells[0].RowIndex;
            globals.GivtList.RemoveAt(n);
            System.IO.File.Delete(@"Givs.xml");
            Giving.Save();
            Print();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(@"Givs.xml");
            Giving.Save();
        }
    }
}
