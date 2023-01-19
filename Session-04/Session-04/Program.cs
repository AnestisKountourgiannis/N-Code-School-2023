// See https://aka.ms/new-console-template for more information
using Session_04;
using System.Security.Cryptography.X509Certificates;
internal class Program
{
    private static void Main(string[] args)
    {
        HelloName helloName = new HelloName();
        Console.WriteLine(helloName.Get());
        Console.ReadLine();
    }
}