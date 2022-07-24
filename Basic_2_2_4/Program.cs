using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sInput = "Мне нравится этот курс! \":)\"";     //Console.ReadLine();
            var s = sInput.Split(' ');
            var result = new StringBuilder();
            foreach (var item in s)
            {
                result.AppendLine(item + " ");
            }
            Console.WriteLine(result.ToString().Trim());
        }
    }
}
