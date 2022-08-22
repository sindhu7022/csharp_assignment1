using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class exchange_of_first_and_last_letters
    {
        static void Main(string[] args)
        {
            Console.WriteLine(test("sindhu"));
            Console.WriteLine(test("s"));
            Console.WriteLine(test("u"));
            Console.ReadLine();
        }


        public static string test(string str)
        {
            return str.Length > 1
                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
    }
}
