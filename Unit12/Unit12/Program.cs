using System;
using System.Numerics;

namespace Unit12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1: Graph Elipse\n2: Create Equation from Elipse points\nSelect a mode: ");
            string mode = Console.ReadLine();
            if (mode == "1")
            {
                graph();
            }
            if (mode == "2")
            {
                equationgen();
            }
        }
        static void graph()
        {
            bool going = true;
            while (true)
            {
                Console.WriteLine("Enter the following variables:");
                Console.WriteLine("(x + a)^2 + (y - b)^2");
                Console.WriteLine("   c           d");
                Console.Write("A: ");
                int a = Int32.Parse(Console.ReadLine());
                Console.Write("B: ");
                int b = Int32.Parse(Console.ReadLine());
                Console.Write("C: ");
                int c = Int32.Parse(Console.ReadLine());
                Console.Write("D: ");
                int d = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Center: ("+ -a+ ","+ -b+")");
                if (c > d)
                {
                    Console.WriteLine("Horizontal points: ");
                    Console.WriteLine(-a - Math.Sqrt(c));
                    Console.WriteLine(-a + Math.Sqrt(c));
                    Console.WriteLine("\nVertical points: ");
                    Console.WriteLine(-b - Math.Sqrt(d));
                    Console.WriteLine(-b + Math.Sqrt(d));
                }
                else
                {
                    Console.WriteLine("Horizontal points: ");
                    Console.WriteLine(-a - Math.Sqrt(c));
                    Console.WriteLine(-a + Math.Sqrt(c));
                    Console.WriteLine("\nVertical points: ");
                    Console.WriteLine(-b - Math.Sqrt(d));
                    Console.WriteLine(-b + Math.Sqrt(d));
                }
                
            }
        }
        static void equationgen()
        {
            Console.WriteLine("Enter the Vertices:");
            double x1 = Double.Parse(Console.ReadLine());
            double y1 = Double.Parse(Console.ReadLine());
            double x2 = Double.Parse(Console.ReadLine());
            double y2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Foci");
            double x3 = Double.Parse(Console.ReadLine());
            double y3 = Double.Parse(Console.ReadLine());
            double x4 = Double.Parse(Console.ReadLine());
            double y4 = Double.Parse(Console.ReadLine());
            Console.WriteLine();
            double center;
            double c;
            if (x1 == x2)
            {
                center = (y1 - y2)/2*-1;
                Console.WriteLine("A: "+center);
                c = y3 - y4 / 2;
                Console.WriteLine("C: " + c);
            }
            else
            {
                center = (x1 - x2) / 2*-1;
                Console.WriteLine("A: " + center);
                c = x3 - x4 / 2;
                Console.WriteLine("C: " + c);
            }
            double tb = center * center - c * c;
            double b = Math.Sqrt(tb);
            Console.WriteLine(b);
            
            if (x1 == x2)
            {
                Console.WriteLine("(x + " + -center + ") = (y + " + -b+")");
            }
            else
            {
                Console.WriteLine("(x + " + -b + ") = (y + " + -center
                    
                    + ")");
            }
        }
    }
}
