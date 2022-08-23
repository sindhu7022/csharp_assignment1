using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class age
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            
            age = age + 10;
	    Console.Write($"after 10 years: {age}");
            
        }
    }
}