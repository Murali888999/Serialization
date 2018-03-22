using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace Serialization
{
    class basicXmlSerialization
    {
        static void xmlwrite()
        {
            book b = new book();
            b.title = ".NetFramework";
            XmlSerializer writer = new XmlSerializer(typeof(book));
            using (FileStream f = File.Create("E:\\mohan.txt"))
            {
                writer.Serialize(f,b);
            }
        }
        static void Main(string[] args)
        {
            xmlwrite();
            Console.ReadKey();
        }
    }
   public  class book
    {
        public string title;
    }
}
