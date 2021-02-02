using System;

namespace Unit11
{
    class Program
    {
        public static bool go;
        static void Main(string[] args)
        {
            while (0 == 0)
            {
                Console.WriteLine("Enter a mode: Sine, Cosine, Area");
                string mode = Console.ReadLine();
                if (mode == "Sine")
                {
                    go = true;
                    while (go)
                    {
                        Console.WriteLine("Type the known angle or quit");
                        double angle1 = 0;
                        try
                        {
                            angle1 = double.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            go = false;
                        }
                        if (go == true)
                        {
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
                if (mode == "Cosine")
                {
                    go = true;
                    while (go)
                    {
                        Console.WriteLine("Enter the first side or quit");
                        double side1 = 0;
                        try
                        {
                            side1 = Double.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            go = false;
                        }
                        if (go)
                        {
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
                            Console.WriteLine("The missing angle is " + Math.Acos(temp2) * 57.2957795);
                        }
                        
                    }
                }
                if (mode == "Area")
                {
                    go = true;
                    while (go)
                    {
                        Console.WriteLine("Enter a side or quit");
                        double side1 = 0;
                        try
                        {
                            side1 = Double.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            go = false;
                        }
                        if (go)
                        {
                            Console.WriteLine("Enter the other side");
                            double side2 = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the angle");
                            double angle1 = Double.Parse(Console.ReadLine());
                            Console.WriteLine("Your area is " + 0.5 * side1 * side2 * Math.Sin(angle1/ 57.2957795));
                        }
                    }
                }
                if (mode == "Angle")
                {
                    double a = Double.Parse(Console.ReadLine());
                    double b = Double.Parse(Console.ReadLine());
                    Console.WriteLine(180 - a - b);
                }
                if (mode == "Numb")
                {
                    go = true;
                    while (go)
                    {
                        double angle=0;
                        Console.WriteLine("What is the angle or quit?");
                        try
                        {
                            angle = double.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            go = false;
                        }
                        if (go)
                        {
                            Console.WriteLine("What is the non-oposite side?");
                            double side1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("What is the opposite side?");
                            double side2 = double.Parse(Console.ReadLine());
                            double high = Math.Sin(angle/ 57.2957795) * side1;
                            int tris = 0;
                            if (high == side2)
                            {
                                //Right triangle
                                tris++;
                            }
                            if (side2 > high)
                            {
                                tris++;
                                if (side2 < side1)
                                {
                                    tris++;
                                }
                            }
                            Console.WriteLine("Your amount of triangles is " + tris);
                        }
                        
                    }
                   

                }
            }
        }
    }
}
