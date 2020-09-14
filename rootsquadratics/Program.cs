using System;

namespace rootsquadratics
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double root1calc, root2calc;
            Console.WriteLine("please enter a");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("please enter b");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("please enter c");
            c = Convert.ToDouble(Console.ReadLine());

            root1calc = calcquadratic1(double a, b, c);
            root2calc = calcquadratic2(double a, b, c);

            static double calcquadratic1(double a, b, c)
            {
                double root1 = (-b + Math.Sqrt(b * b + (4 * a * b))) / 2 * a; 
              
                return (root1);
            }


            static double calcquadratic2(double a, b, c)
            {
                double root2 = (-b + Math.Sqrt(b * b - (4 * a * b))) / 2 * a;

                return (root2);
            }
        }

       
        
    }
}
