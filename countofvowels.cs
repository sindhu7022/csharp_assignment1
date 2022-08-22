using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class countofvowels
    {
       public static void Main(String[] args)
        {
            int i, count = 0;
            Console.WriteLine("enter a string");
            string str = Convert.ToString(Console.ReadLine());
            
        }
        for(i = 0; i<len; i++)
    {
         
        
        if (str[i]=='a' || str[i]== 'e' ||
            str[i]== 'i' || str[i]== 'o' ||
           str[i]== 'u' || str[i]== 'A' ||
            str[i]== 'E' || str[i]== 'I' ||
            str[i]== 'O' || str[i]== 'U')
        {
             
            
            count++;
        }
}
Console.WriteLine($"no of vowels are {count}");
}
}




