using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            
            
            // Exercise 1
            int sum = a + b;
            Console.WriteLine($"The sum of 17 + 4 is {sum}.");

            int difference = a - b;
            Console.WriteLine($"The difference of 17 - 4 is {difference}.");

            int product = a * b; 
            Console.WriteLine($"The product of 17 x 4 is {product}.");

            int quotient = a / b;
            Console.WriteLine($"The quotient of 17 / 4 is {quotient}.");

            int remainder = a % b;
            Console.WriteLine($"The remainder of 17 / 4 is {remainder}.");

            if (a == 17 && b == 4);
            Console.WriteLine($"17 / 4 is {quotient} remainder {remainder}."
                + Environment.NewLine
                + Environment.NewLine);


            // Exercise 2
            Console.WriteLine("What is the radius of your circle ?");
            var radius = double.Parse(Console.ReadLine());

            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of your circle with a radius of {radius} is {area}");

        }

        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
         }
    }
}
