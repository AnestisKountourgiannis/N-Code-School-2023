﻿// See https://aka.ms/new-console-template for more information
using Session_04;
using System.Security.Cryptography.X509Certificates;
public class Program
{
    private static void main(string[] args)
    {
        HelloName helloName = new HelloName();
        Console.WriteLine(helloName.Get());
        Console.ReadLine();
    }
}

public class SumDivision
{
    private void main(string[] args)
    {
        SumDivision sumdivision = new SumDivision();
        Console.WriteLine(sumdivision.GetHashCode());
    }
}
