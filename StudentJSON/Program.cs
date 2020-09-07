using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace StudentJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            //List<Student> stu = new List<Student>()
            //{
            //   new Student
            //   {
            //       Name="Raji",
            //       Class=4,
            //       RollNo=1,
            //       Subject=new string[]
            //       {
            //           "Java",
            //           "C"

            //       }
            //   },
            //   new Student
            //    {
            //       Name="Vinay",
            //       Class=4,
            //       RollNo=1,
            //       Subject=new string[]
            //       {
            //           "Asp",
            //           "Rpa"

            //       }
            //   }
            //};
    string JSONresult = JsonConvert.SerializeObject(stu);
            string path = @"F:\API\JSON\Student.Json";
            if (File.Exists(path))
            {
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
            }
            else if (!File.Exists(path))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(JSONresult.ToString());
                    tw.Close();
                }
            }

        }
    }
}
