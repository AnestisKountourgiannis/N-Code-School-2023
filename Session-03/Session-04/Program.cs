using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args) 
    { 


        Console.WriteLine("Hello, World!");

        
        string hello = "Hello";
    string name = "Anestis";

    Console.WriteLine(hello + " " + name);

        HelloName helloName = new HelloName();
    Console.WriteLine(helloName.Get());

        Console.ReadLine();

    }
}