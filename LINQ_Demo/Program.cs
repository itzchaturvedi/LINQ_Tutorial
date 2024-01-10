using System;
using System.Linq; // Namespace for LINQ
class Program
{
    static void Main(string[] args)
    {
        //Collection DataSource
        int[] age = { 16, 18, 30, 23, 12, 23, 13, 14, };
        //LINQ Query
        var a = from i in age where i > 20 select i;

        foreach (int item in a)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}