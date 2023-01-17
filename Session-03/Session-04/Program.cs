// See https://aka.ms/new-console-template for more information
internal class Program
{ private static void Main(string[] args)
    {
        string hello = "Hello";
        string name = "Anestis";
        Console.WriteLine(hello + " " + name);
        HelloName helloName = new HelloName();
        Console.WriteLine(helloName.Get());
        Console.ReadLine();

    }
}