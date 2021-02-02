using System;

namespace Law_of_Cosines
{
    class Program
    {
        static void Main(string[] args)
        {
            while (0 == 0)
            {
                Console.WriteLine("Enter the first side");
                double side1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second side");
                double side2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the angle or other side");
                double angle1 = Double.Parse(Console.ReadLine());
                double temp1 = side1 * side2 * 2 * Math.Cos(angle1 / 57.2957795);
                //Console.WriteLine(temp1);
                double temp2 = ((side1 * side1) + (side2 * side2)) - temp1;
                Console.WriteLine("The missing side is " + Math.Sqrt(temp2));


                temp1 = (angle1 * angle1) - (side1 * side1) - (side2 * side2);
                temp2 = temp1 / (-2 * side1 * side2);
                //Console.WriteLine(temp2);
                Console.WriteLine("The missing angle is " + Math.Acos(temp2)* 57.2957795);
            }
            

        }
    }
}
