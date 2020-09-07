using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConvertigStudentson_C_object
{
    public class Program
    {
        public static void Main(string[] args)
        {

            using (StreamReader r = new StreamReader(@"F:\API\JSON\Student.Json"))
            {
                string json = r.ReadToEnd();
                Student Sobject = JsonConvert.DeserializeObject<Student>(json);
                //dynamic array = JsonConvert.DeserializeObject(json);
                //Console.WriteLine(array);

                //List<Student> Sobject = JsonConvert.DeserializeObject<List<Student>>(json);
                //foreach (var item in Sobject)

                //{
                //    Console.WriteLine(item.Name);
                //    Console.WriteLine(item.Class);
                //    Console.WriteLine(item.RollNo);
                //    foreach (var value in item.Subject)
                //    {
                //        Console.WriteLine(value);
                //    }

                Console.WriteLine(Sobject.Name);
                Console.WriteLine(Sobject.Class);
                Console.WriteLine(Sobject.RollNo);
                foreach (object value in Sobject.Subject)
                {
                    Console.WriteLine(value);
                }
                Console.ReadLine();
            }
        }

            //Console.WriteLine( "{0}", item.Subject);
            //Console.WriteLine("{1}", item.Subject);
        
        public class Student
        {
            public string Name;
            public int Class;
            public int RollNo;
            public string[] Subject;

        }


    }
}

