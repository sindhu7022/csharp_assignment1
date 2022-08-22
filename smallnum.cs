using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class smallno
    {
        static void Main()
        {
            int n1, n2;
            Console.WriteLine("enter first number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter sec number");
            n2 = Convert.ToInt32(Console.ReadLine());
            var small = n1 > n2 ? "n2 is small" : "n1 is small";
            Console.WriteLine(small);
        }
    }
}
