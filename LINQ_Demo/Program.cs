using System;
using System.Linq; // Namespace for LINQ
class Program
{
    static void Main(string[] args)
    {
        //Collection DataSource
        //int[] age = { 16, 18, 30, 23, 12, 23, 13, 14, };

        //LINQ Query
        //var a = from i in age where i > 20 select i;


        //ORDERBY
        //var a = from i in age where i > 20 orderby i descending select i;


        //foreach (int item in a)
        //{
        //    Console.WriteLine(item);
        //}

        //Now perform some operations on the string 


        /*
         Few built in methods in LINQ String 
        Contains(" ")
        StartsWith(" ")
         * */


        string[] names = { "Priyanshu", "Ishan", "Ankit", "Surya", "Bhavesh", "Shani" };
        var a = from name in names where name.Contains("ansh") select name;
        foreach (string item in a)
        {
            Console.WriteLine(item);
        }

        Console.ReadLine();
    }
}