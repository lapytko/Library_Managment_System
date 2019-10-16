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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                MessageBox.Show(this, "Введите слово для поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string s = SearchBox.Text;
                s.Trim();
                if (radioBook.Checked)
                {
                    globals.Search = Book.Search(s.ToLower());
                    if (globals.Search.Length > 0)
                    {
                        globals.isGood = true;
                        globals.SearchFlag = 1;
                        SearchResults result = new SearchResults();
                        result.Text += " по запросу: \"" + s+"\"";
                        this.Close();
                        result.ShowDialog();
                    }
                    else
                    {
                        globals.isGood = false;
                    }
                }
                if (radioRead.Checked)
                {
                    globals.Search = Student.Search(s.ToLower());
                    if (globals.Search.Length > 0)
                    {
                        globals.isGood = true;
                        globals.SearchFlag = 2;
                        SearchResults result = new SearchResults();
                        result.Text += " по запросу: \"" + s + "\"";
                        this.Close();
                        result.ShowDialog();
                    }
                    else
                    {
                        globals.isGood = false;
                    }
                }
                if (radioGiv.Checked)
                {
                    globals.Search = Giving.Search(s.ToLower());
                    if (globals.Search.Length > 0)
                    {
                        globals.isGood = true;
                        globals.SearchFlag = 3;
                        SearchResults result = new SearchResults();
                        result.Text += " по запросу: \"" + s + "\"";
                        this.Close();
                        result.ShowDialog();
                    }
                    else
                    {
                        globals.isGood = false;
                    }
                }
                if (!(radioBook.Checked) && (!radioRead.Checked) && (!radioGiv.Checked))
                {
                    MessageBox.Show(this, "Выберите область поиска!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (globals.isGood == false)
                {
                    if ((SearchBox.Text == ""))
                    {
                        return;
                    }
                    else
                    {
                        MessageBox.Show(this, "Ничего не найдено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}

