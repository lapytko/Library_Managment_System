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
    public partial class EditBook : Form
    {
        public EditBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;
            foreach (Book o in globals.BookList)
            {
                if (o.isbn== ISBNBox.Text) { k = globals.BookList.IndexOf(o); }
            }
            Book Editable = globals.BookList[k];
            Editable.author = AuthorBox.Text;
            Editable.title = TitleBox.Text;
            Editable.publish = PubBox.Text;
            Editable.year = YearBox.Text;
            Editable.create= DateTime.Now.ToShortDateString();
            Book.Save();
            this.Close();
        }
    }
}
