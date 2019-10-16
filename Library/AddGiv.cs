using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Library
{
    public partial class AddGiv : Form
    {
        public List<string> tmp = new List<string>();
        public AddGiv()
        {
            InitializeComponent();
        }

        public bool Reader_Search(string ticket)
        {
            bool res = false;
            if (globals.StudentList.Count > 0)
            {
                int n = -1;
                foreach (Student o in globals.StudentList)
                {
                    if (o.ticket == ticket)
                    {
                        n = globals.StudentList.IndexOf(o);
                    }
                }
                if (n > -1)
                {
                    res = true;
                }
                return res;
            }
            else
            {
                MessageBox.Show(this, "Добавте читателей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return res;
            }
        }

        private void AddGiv_Load(object sender, EventArgs e)
        {
            foreach (Book o in globals.BookList)
            {
                ComboboxItem item = new ComboboxItem();
                item.Text = o.author + " \"" + o.title + "\"";
                item.Value = globals.BookList.IndexOf(o);
                BookBox.Items.Add(item);
            }
            BookBox.DropDownWidth = DropDownWidth(BookBox);
            givBox.Text = DateTime.Now.ToShortDateString();

        }

        public string[] ListToArray(List<Book> books)
        {
            string[] SArr = new string[books.Count];
            foreach (Book o in books)
            {
                int i = books.IndexOf(o);
                SArr[i] = o.author + ". \"" + o.title + "\"";

            }
            return SArr;
        }

        int DropDownWidth(System.Windows.Forms.ComboBox myCombo)
        {
            int maxWidth = 0;
            int temp = 0;
            System.Windows.Forms.Label label1 = new System.Windows.Forms.Label();

            foreach (var obj in myCombo.Items)
            {
                label1.Text = obj.ToString();
                temp = label1.PreferredWidth;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            label1.Dispose();
            return maxWidth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = BookBox.SelectedIndex;
            int k = -1;
            foreach (string c in tmp)
            {
                if (c == globals.BookList[i].isbn)
                {
                    k = tmp.IndexOf(c);
                }
            }
            if (k > -1)
            {
                MessageBox.Show(this, "Такая книга уже добавлена!", ":-/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                listBook.Items.Add(globals.BookList[i].title);
                tmp.Add(globals.BookList[i].isbn);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string reader = TicketBox.Text;
            if (Reader_Search(reader))
            {
                string giv = givBox.Text;
                string get = getBox.Text;
                string[] books = tmp.ToArray();
                Giving ng = new Giving(reader, get, books);
                globals.GivtList.Add(ng);
                Giving.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Такого читателя нет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
    }



    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }

    }
}


