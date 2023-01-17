using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class HelloName
{
    private static void Main(string[] args)
    { 
        string hello = "Hello";
        string name = "Anestis";

      Console.WriteLine(hello + " " + name);
        Console.ReadLine();
    }
}
public class Exercise2
{
    public static void Main()
    {
        int NumberA = 8;
        int NumberB = 2;
        Console.WriteLine(NumberA+NumberB);
        Console.WriteLine(NumberA/NumberB);
    }
}
int Act1 = ((-1) + (5 * 6) );
Console.WriteLine(Act1);
int Act2 = (38 + (5 % 7));
Console.WriteLine(Act2);
float Act3 = (14 + (((-3) * 6) / 7));
Console.WriteLine(Act3);
double Act4 = ((2 + (13 / 6)) * 6 + Math.Sqrt(7));
Console.WriteLine(Act4);
int Act5 = ((6 ^ 4) + (5 ^ 7) / ((9 % 4)));
Console.WriteLine(Act5);

int n = 129600;

int year = n / (365 * 86400);

n = n % (365 * 86400);
int day = n / (24 * 3600);

n = n % (24 * 3600);
int hour = n / 3600;

n %= 3600;
int minutes = n / 60;

n %= 60;
int seconds = n;

Console.WriteLine(year + " " + "years " + day + " " + "days " + hour + " " + "hours " + minutes + " " + "minutes " + seconds + " " + "seconds ");