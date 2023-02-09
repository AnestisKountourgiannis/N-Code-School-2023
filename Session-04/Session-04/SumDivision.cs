using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    public class SumDivision
    {
        public static void main(string[] args)
        {

            Console.Write("A: ");

            string num1Input = Console.ReadLine();
            int num1;

            while (!(int.TryParse(num1Input, out num1)) || num1 <= 0)
            {
                Console.WriteLine("\r\nPlease type in a positive integer");
                Console.Write("A: ");
                num1Input = Console.ReadLine();
            }

            Console.Write("B: ");

            string num2Input = Console.ReadLine();
            int num2;


            while (!(int.TryParse(num2Input, out num2)) || num2 <= 0)
            {
                Console.WriteLine("\r\nPlease type in a positive integer");
                Console.Write("B: ");
                num2Input = Console.ReadLine();
            }

            int sum = num1 + num2;
            int division = num1 / num2;
            Console.WriteLine("\r\nThe sum of {0} + {1} is {2}", num1, num2, sum);
            Console.WriteLine("\r\nThe division of {0} / {1} is {2}", num1, num2, division);
        }
    }
}
