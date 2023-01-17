using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

string hello = "Hello";
string name = "Fotis";

Console.WriteLine(hello + " " + name);

HelloName helloName = new HelloName();
Console.WriteLine(helloName.Get());

Console.ReadLine();