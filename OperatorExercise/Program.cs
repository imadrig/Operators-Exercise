namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            
            int remainder = a % b;

            int sum = a + b;
            Console.WriteLine($"The sum of 17 + 4 is {sum}.");

            int difference = a - b;
            Console.WriteLine($"The difference of 17 - 4 is {difference}.");

            int product = a * b; 
            Console.WriteLine($"The product of 17 x 4 is {product}.");


        }
    }
}
