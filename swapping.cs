// See https://aka.ms/new-console-template for more information


using System;
public class SwapExample
{
    public static void Swap(ref int a, ref int b)
    {
        // a = a * b;
        //b = a / b;
        //a = a / b;  //using operations
        
        int c = a;
        a = b; b = c; //using third var

        
    }
    public static void Main(String[] args)
    {
        int a = 5, b = 10;
        Console.WriteLine($"before swap a= {a} b= {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"after swap a= {a} b= {b}");
    }
}