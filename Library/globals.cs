using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.IO;

namespace Library
{
    public class globals
    {
        public static List<Book> BookList = new List<Book>();
        public static List<Student> StudentList = new List<Student>();
        public static List<Giving> GivtList = new List<Giving>();
        public static int[] Search;
        public static bool isGood = false;
        public static Byte SearchFlag=0;
    }
}
