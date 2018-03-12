using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NTTU_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\admin\Desktop\lab-2-zi-chuan-chu-li-e1018e1018\Data\Input.txt");
            String line;
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                var chars = line.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == '.' || chars[i] == '?' || chars[i] == '!')
                    {
                        Console.WriteLine(chars[i]);
                    }
                    else
                    {
                        Console.Write(chars[i]);
                    }              
                }
            }
            Console.Read();  
        }
    }
}