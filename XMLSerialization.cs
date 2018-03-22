using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Serialization
{
    class XMLSerialization
    {
        static  void Xmlwrite()
          {
            author a = new author();
            a.name = "Ramesh";
            a.bookname = "Java";
            a.age = 45;
            XmlSerializer writer = new XmlSerializer(typeof(author)); 
            using (FileStream fs =File.Create("e:\\abcd.txt"))
            {
                writer.Serialize(fs, a);
            }
          }
        static void Xmlread()
        {
            XmlSerializer reader = new XmlSerializer(typeof(author));
            using (StreamReader sr = new StreamReader("e:\\abcd.txt"))
            {
                author a = (author)reader.Deserialize(sr);
            }
        }
        
        static void Main(string[] args)
        {
           Xmlwrite();
           Xmlread();
            Console.ReadKey();
        }
    }
   public  class author
    {
       public  string name;
       public string bookname;
       public  int age;       
    }
}
