using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Library
{
    public class Student
    {
        public string ticket;
        public string fname;
        public string name;
        public string lname;
        public DateTime bith;
        public string phone;
        public string adress;


        public Student() { }
        public Student(string ticket, string fname, string name, string lname, string bith, string phone, string adr)
        {
            this.ticket = ticket;
            this.fname = fname;
            this.name = name;
            this.lname = lname;
            this.bith = ToDateTime(bith, '.');
            this.phone = phone;
            this.adress = adr;
        }

        public static DateTime ToDateTime(string datetime, char dateSpliter = '.')

        {
            DateTime DT = new DateTime();
            datetime = datetime.Trim();
            DT = DateTime.Parse(datetime);
            return DT;
        }

        public static void Save()
        {
            globals.StudentList.Sort(new FIOComparer());
            string filename = @"Students.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, globals.StudentList);
                fs.Close();
            }
        }

        public static int[] Search(string s)
        {
            List<int> n = new List<int>();
            foreach (Student o in globals.StudentList)
            {
                string tmp;
                tmp = o.name.ToLower();
                if (tmp.Contains(s)) { n.Add(globals.StudentList.IndexOf(o)); }
                tmp = o.lname.ToLower();
                if (tmp.Contains(s)) { n.Add(globals.StudentList.IndexOf(o)); }
                tmp = o.fname.ToLower();
                if (tmp.Contains(s)) { n.Add(globals.StudentList.IndexOf(o)); }
                tmp = o.adress.ToLower();
                if (tmp.Contains(s)) { n.Add(globals.StudentList.IndexOf(o)); }
                tmp = o.phone;
                if (tmp.Contains(s)) { n.Add(globals.StudentList.IndexOf(o)); }
                tmp = o.ticket;
                if (tmp.Contains(s)) { n.Add(globals.StudentList.IndexOf(o)); }
                tmp = o.bith.ToShortDateString();
                if (tmp.Contains(s)) { n.Add(globals.StudentList.IndexOf(o)); }

            }
            return n.ToArray();
        }

        public static void SaveRes(string path, int[] numders)
        {
            List<Student> tmp = new List<Student>();
            for (int i = 0; i < globals.Search.Length; i++)
            {
                Student o = globals.StudentList[numders[i]];
                tmp.Add(o);
            }
            globals.BookList.Sort(new AuthorComparer());
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, tmp);
                fs.Close();
            }

        }

        public static void Load()
        {
            string filename = @"Students.xml";
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                try
                {
                    globals.StudentList = (List<Student>)serializer.Deserialize(fs);
                    fs.Close();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message+' '+filename);

                }

            }
        }
    }

    class FIOComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            string s1 = x.lname[0].ToString();
            string s2 = y.lname[0].ToString();
            s1.ToLower(); s2.ToLower();
            return String.Compare(s1, s2);
        }
    }

    class TicketComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return String.Compare(x.ticket, y.ticket);
        }
    }

    class BithComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return DateTime.Compare(x.bith, y.bith);
        }
    }
}
