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
    public partial class ViewBookList : Form
    {
        public ViewBookList()
        {
            InitializeComponent();
        }
        private void ViewBookList_Load(object sender, EventArgs e)
        {
            Book.Load();
            BookGrid.Rows.Clear();
            Print();
        }

        /// <summary>
        /// Добавить книгу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            AddBook addBook = new AddBook();
            addBook.MdiParent = this.MdiParent;
            addBook.Show();
        }

        /// <summary>
        /// Обновить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            BookGrid.Rows.Clear();
            Print();
        }

        /// <summary>
        /// Удалить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            int n = BookGrid.SelectedCells[0].RowIndex;
            globals.BookList.RemoveAt(n);
            System.IO.File.Delete(@"Books.xml");
            Book.Save();
            Print();
        }

        /// <summary>
        /// Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Book.Save();
        }

        // сортировки
        private void поНазваниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globals.BookList.Sort(new TitleComparer());
            BookGrid.Rows.Clear();
            Print();
        }
        private void поАвторуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globals.BookList.Sort(new AuthorComparer());
            Print();
        }
        private void поИздательствуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globals.BookList.Sort(new PubComparer());
            Print();
        }
        private void поДатеДобавленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globals.BookList.Sort(new CreateComparer());
            Print();
        }

        /// <summary>
        /// Редактирование
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            int n = BookGrid.SelectedCells[0].RowIndex;
            EditBook Edit = new EditBook();
            Edit.MdiParent = this.MdiParent;
            Edit.ISBNBox.Text = globals.BookList[n].isbn;
            Edit.AuthorBox.Text = globals.BookList[n].author;
            Edit.TitleBox.Text = globals.BookList[n].title;
            Edit.PubBox.Text = globals.BookList[n].publish;
            Edit.YearBox.Text = globals.BookList[n].year;
            Edit.Show();
        }

        /// <summary>
        /// Вывод данных в таблицу
        /// </summary>
        public void Print()
        {
            BookGrid.Rows.Clear();
            foreach (Book o in globals.BookList)
            {
                int n = BookGrid.Rows.Add();
                //BookGrid.Rows[n].Cells[0].Value = globals.BookList.IndexOf(o)+1;
                BookGrid.Rows[n].Cells["ISBN"].Value = o.isbn;
                BookGrid.Rows[n].Cells["Author"].Value = o.author;
                BookGrid.Rows[n].Cells["Title"].Value = o.title;
                BookGrid.Rows[n].Cells["Pub"].Value = o.publish;
                BookGrid.Rows[n].Cells["Year"].Value = o.year;
                BookGrid.Rows[n].Cells["Create"].Value = o.create;
            }
        }
    }

}

