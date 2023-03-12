using System;

namespace TriangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the coordinates of three points of the triangle:");

            Console.Write("Enter x-coordinate of Point A: ");
            double xa;
                while (!double.TryParse(Console.ReadLine(), out xa))
                {
                    Console.WriteLine("Invalid input. Please enter correct value for x-coordinate of Point A.");
                }

            Console.Write("Enter y-coordinate of Point A: ");
            double ya;
                while (!double.TryParse(Console.ReadLine(), out ya))
                {
                    Console.WriteLine("Invalid input. Please enter correct value for y-coordinate of Point A.");
                }

            Console.Write("Enter x-coordinate of Point B: ");
            double xb;
                while (!double.TryParse(Console.ReadLine(), out xb))
                {
                    Console.WriteLine("Invalid input. Please enter correct value for x-coordinate of Point B.");
                }

            Console.Write("Enter y-coordinate of Point B: ");
            double yb;
                while (!double.TryParse(Console.ReadLine(), out yb))
                {
                    Console.WriteLine("Invalid input. Please enter correct value for y-coordinate of Point B.");
                }

            Console.Write("Enter x-coordinate of Point C: ");
            double xc;
                while (!double.TryParse(Console.ReadLine(), out xc))
                {
                    Console.WriteLine("Invalid input. Please enter correct value for x-coordinate of Point C.");
                }

            Console.Write("Enter y-coordinate of Point C: ");
            double yc;
                while (!double.TryParse(Console.ReadLine(), out yc))
                {
                    Console.WriteLine("Invalid input. Please enter correct value for y-coordinate of Point C.");
                }

            double a = Distance(xa, ya, xb, yb);
            double b = Distance(xb, yb, xc, yc);
            double c = Distance(xc, yc, xa, ya);

            bool isEquilateral = IsEquilateral(a, b, c);

            bool isIsosceles = IsIsosceles(a, b, c);

            bool isRight = IsRight(a, b, c);

            double perimeter = a + b + c;

            Console.WriteLine("Length of AB is: " + a);
            Console.WriteLine("Length of BC is: " + b);
            Console.WriteLine("Length of AC is: " + c);
            Console.WriteLine($"Triangle IS{(isEquilateral ? "" : " NOT")} Equilateral");
            Console.WriteLine($"Triangle IS{(isIsosceles ? "" : " NOT")} Isosceles");
            Console.WriteLine($"Triangle IS{(isRight ? "" : " NOT")} Right");
            Console.WriteLine("Perimeter: {0}", perimeter);
            Console.Write("Even numbers up to perimeter: ");
            for (int i = 0; i <= perimeter; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        static bool IsEquilateral(double a, double b, double c)
        {
            return a == b && b == c;
        }

        static bool IsIsosceles(double a, double b, double c)
        {
            return a == b || b == c || c == a;
        }

        
        static bool IsRight(double a, double b, double c)
        {
    
            double longestSide = Math.Max(Math.Max(a, b), c);
            double hypotenuseSquare = longestSide * longestSide;
            double sidesSquare = a * a + b * b + c * c - longestSide * longestSide;
            double delta = hypotenuseSquare - sidesSquare;

            if (Math.Round(delta, 3) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

           
