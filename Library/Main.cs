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
    public partial class Main : Form
    {
        Search IsOpen = null;
        ViewBookList bookList = null;
        AddBook add = null;
        AddReader reader = null;
        public Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void добавитьНовуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (add == null)
            {
                AddBook addBook = new AddBook();
                addBook.MdiParent = this;
                addBook.FormClosed += new FormClosedEventHandler(addBook_FormClosed);
                addBook.Show();
            }
        }

        void addBook_FormClosed(object sender, EventArgs e)
        {
            add = null;
            Book.Save();
            Giving.Save();
            Student.Save();
        }

        private void посмотретьКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bookList == null)
            {
                ViewBookList ViewList = new ViewBookList();
                ViewList.MdiParent = this;
                ViewList.FormBorderStyle = FormBorderStyle.FixedDialog;
                ViewList.FormClosed += ViewList_FormClosed;
                ViewList.Show();
            }

        }

        private void ViewList_FormClosed(object sender, FormClosedEventArgs e)
        {
            bookList = null;
        }

        private void добавитьНовогоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (reader == null)
            {
                AddReader NewReader = new AddReader();
                NewReader.MdiParent = this;
                NewReader.FormClosed += new FormClosedEventHandler(NewReader_FormClosed);
                NewReader.Show();
            }
        }

        void NewReader_FormClosed(object sender, EventArgs e)
        {
            reader = null;
            Student.Save();
        }

        private void просмотретьСписокЧитателейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentView studentView = new StudentView();
            studentView.MdiParent = this;
            studentView.FormBorderStyle = FormBorderStyle.FixedDialog;
            studentView.AutoSize = true;
            studentView.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Giving.Save();
            Student.Save();
            Book.Save();

        }

        private void создатьВыдачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGiv NewGiv = new AddGiv();
            NewGiv.MdiParent = this;
            NewGiv.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        { 
            Book.Load();
            Student.Load();
            Giving.Load();
        }

        private void списокВыдачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GivList givs = new GivList();
            givs.MdiParent = this;
            givs.Show();


        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search search = new Search(); ;
            if (IsOpen == null)
            {
                IsOpen = search;
                search.FormClosed += new FormClosedEventHandler(SearchClose);
                search.ShowDialog();
            }
        }

        private void SearchClose(object sender, FormClosedEventArgs e)
        {
            IsOpen = null;
        }

    }
}