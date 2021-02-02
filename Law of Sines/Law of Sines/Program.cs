using System;
namespace Law_of_Sines
{
    class Program
    {
        static void Main(string[] args)
        {
            while (0 == 0)
            {
                Console.WriteLine("Type the known angle");
                double angle1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Type the known side");
                double side1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Type the opposite of the unknown");
                double unknow = double.Parse(Console.ReadLine());

                double temp1 = (Math.Sin(unknow / 57.2957795) * side1) / Math.Sin(angle1 / 57.2957795);
                Console.WriteLine("The missing side is " + temp1);


                double temp2 = (unknow * Math.Sin(angle1 / 57.2957795) / side1);
                double temp3 = (Math.Asin(temp2) * 57.2957795);


                Console.WriteLine("The missing angle is " + temp3);
            }
            
        }
    }
}
