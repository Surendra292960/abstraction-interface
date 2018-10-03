using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization.Serialization
{
    [Serializable]
    class Student2
    {
        public int rollno;
        public string name;
        public Student2(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    public class DeserializeExample
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream("g:\\Surendra.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            //Student2 s = (Student2)formatter.Deserialize(stream);


            try
            {
                Student2 s = (Student2)formatter.Deserialize(stream);
                Console.WriteLine("Conversion succeeded.");
                Console.WriteLine("Rollno: " + s.rollno);
                Console.WriteLine("Name: " + s.name);
            }
            catch (InvalidCastException e)
            {
               
                Console.WriteLine(e.Message);
            }


            stream.Close();
            Console.Read();
        }
    }
}
