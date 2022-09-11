using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentDataRetrieve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.Create("StuData.txt");
            FileStream fs = new FileStream("StuData.txt",FileMode.Open,FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            while (true)
            {
                string sd = sr.ReadLine();

                if (sd==null)
                {
                    Console.WriteLine("No data...");
                    break;
                }

                Console.WriteLine("Student name: " + sd);

                Console.ReadKey();
            }
        }
    }
}
