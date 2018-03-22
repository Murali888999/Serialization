using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    [Serializable]
    class employee
    {
        int empid;
      [NonSerialized]
        string empname;

        public employee(int empid, string empname)
        {
            this.empid = empid;
            this.empname = empname;
        }
    }
   public  class BinarySerialization
    { 
        static void serialize()
        {
            FileStream fs = new FileStream("e:\\murali123.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            employee obj = new employee(232, "Murali");
            bf.Serialize(fs, obj);
            fs.Close();
            //fs = File.Open("e:\\murali.txt",FileMode.OpenOrCreate);
            //employee e = (employee)bf.Deserialize(fs);
            //Console.WriteLine(e);
        }
        static void Main(string[] args)
        {
            serialize();
            Console.ReadKey();
        }
    }
}
