using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Object_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            string JSONresult = JsonConvert.SerializeObject(emp);
            string path = @"F:\API\JSON\Employee.Json"; 
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
