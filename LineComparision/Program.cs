using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1;
            int y1;

            Console.WriteLine("Enter the 1st co-ordinates x1");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 1st co-ordinates y1");
            y1 = Convert.ToInt32(Console.ReadLine());

            int x2;
            int y2;

            Console.WriteLine("Enter the 1st co-ordinates x2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 1st co-ordinates y2");
            y2 = Convert.ToInt32(Console.ReadLine());

            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("length of the line is :- " + length);

            Console.ReadLine();

        }
    }
}
