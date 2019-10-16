using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace Library
{
    [Serializable]
    public class Giving
    {
        public string id;
        public bool status; //false - не сдано
        public DateTime create;
        public DateTime expirie;
        public string reader;
        public string[] books;

        public Giving() { }
        public Giving(string reader, string exp, string[] books)
        {
            this.id = GenId();
            this.status = false;
            this.create = DateTime.Now;
            this.reader = reader;
            this.expirie = DateTime.Parse(exp);
            this.books = books;

        }
        public static void Save()
        {
            string filename = @"Givs.xml";
            try
            {
                globals.BookList.Sort(new AuthorComparer());
                XmlSerializer serializer = new XmlSerializer(typeof(List<Giving>));
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    serializer.Serialize(fs, globals.GivtList);
                    fs.Close();
                }
            }
            catch(Exception e)
            {
               MessageBox.Show( e.Message.ToString()+' '+filename);
            }
        }

        public static int[] Search(string s)
        {
            List<int> n = new List<int>();
            foreach (Giving o in globals.GivtList)
            {
                string tmp;
                tmp = o.id.ToLower();
                if (tmp.Contains(s)) { n.Add(globals.GivtList.IndexOf(o)); }
            }
            return n.ToArray();
        }
        public static int[] SearchExp(string s)
        {
            DateTime x = ToDateTime(s);
            List<int> n = new List<int>();
            foreach (Giving o in globals.GivtList)
            {
                DateTime tmp;
                tmp = o.expirie;
                if ((tmp<x)&&(o.status==false)) { n.Add(globals.GivtList.IndexOf(o)); }
            }
            return n.ToArray();
        }

        private static DateTime ToDateTime(string datetime, char dateSpliter = '.')

        {
            DateTime DT = new DateTime();
            datetime = datetime.Trim();
            DT = DateTime.Parse(datetime);
            return DT;
        }

        public static void SaveRes(string path, int[] numders)
        {
            List<Giving> tmp = new List<Giving>();
            for (int i = 0; i < globals.Search.Length; i++)
            {
                Giving o = globals.GivtList[numders[i]];
                tmp.Add(o);
            }
            globals.BookList.Sort(new AuthorComparer());
            XmlSerializer serializer = new XmlSerializer(typeof(List<Giving>));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, tmp);
                fs.Close();
            }

        }

        public static void Load()
        {
            string filename = @"Givs.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Giving>));
            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    globals.GivtList = (List<Giving>)serializer.Deserialize(fs);
                    fs.Close();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private string GenId()
        {
            Random r = new Random();
            string num = "";
            do
            {
                int k = r.Next(0, 9);
                num += k.ToString();
            }
            while (num.Length <= 5);
            return num;
        }

        private string SearchBook(string isbn)
        {
            string tmp="";
            int n = 0;
            foreach (Book o in globals.BookList)
            {

                if (o.isbn == isbn)
                {
                    n = globals.BookList.IndexOf(o);
                }
                tmp = globals.BookList[n].author + " \"" + globals.BookList[n].title + "\"";
                
            }
            return tmp;
        }

        public override string ToString()
        {
            string tmp="", book="";
            string nline = "\r";
            for (int i = 0; i < this.books.Length; i++)
            {
                book = SearchBook(this.books[i]);
                tmp += " " + book + nline;
                book = "";
            }
            return tmp;
        }
    }
}
