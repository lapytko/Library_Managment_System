using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Library
{
    [Serializable]
    public class Book
    {
        public string isbn;
        public string author;
        public string title;
        public string publish;
        public string year;
        public string create;

        public Book() { }
        public Book(string isbn, string author, string title, string publish, string year)
        {
            this.isbn = isbn;
            this.author = author;
            this.title = title;
            this.publish = publish;
            this.year = year;
            this.create = DateTime.Now.ToShortDateString();
        }


        /// <summary>
        /// Сохранение Изменений в списке книг
        /// </summary>
        public static void Save()
        {
            globals.BookList.Sort(new AuthorComparer());
            string filename = @"Books.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, globals.BookList);
                fs.Close();
            }

        }
        public static void SaveRes(string path, int[] numders)
        {
            List<Book> tmp = new List<Book>();
            for (int i = 0; i < globals.Search.Length; i++)
            {
                Book o = globals.BookList[numders[i]];
                tmp.Add(o);
            }
            globals.BookList.Sort(new AuthorComparer());
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, tmp);
                fs.Close();
            }

        }

        /// <summary>
        /// Загрузка изменений из файла
        /// </summary>
        public static void Load()
        {
            string filename = @"Books.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Book>));
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                try
                {
                    globals.BookList = (List<Book>)serializer.Deserialize(fs);
                    fs.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

            }
        }

        /// <summary>
        /// Поиск
        /// </summary>
        /// <param name="s">Строка поиска </param>
        /// <returns>Массив номеров из списка книг, совпадающих с критерием поиска</returns>
        public static int[] Search(string s)
        {
            List<int> n = new List<int>();
            foreach (Book o in globals.BookList)
            {
                string tmp;
                tmp = o.isbn.ToLower();
                if (tmp.Contains(s)) { n.Add(globals.BookList.IndexOf(o)); }
                tmp = o.author.ToLower();
                if (tmp.Contains(s)) { n.Add(globals.BookList.IndexOf(o)); }
                tmp = o.title.ToLower();
                if (tmp.Contains(s)) { n.Add(globals.BookList.IndexOf(o)); }
                tmp = o.publish.ToLower();
                if (tmp.Contains(s)) { n.Add(globals.BookList.IndexOf(o)); }
                tmp = o.year;
                if (tmp.Contains(s)) { n.Add(globals.BookList.IndexOf(o)); }

            }
            return n.ToArray();
        }
    }


    class TitleComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return String.Compare(x.title, y.title);
        }

    }
    class AuthorComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return String.Compare(x.author, y.author);
        }

    }
    class PubComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return String.Compare(x.publish, y.publish);
        }

    }
    class CreateComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return String.Compare(x.create, y.create);
        }

    }
}
