namespace ConsoleApp107
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num1");
            double num1=Convert.ToInt64 (Console.ReadLine());
            Console.WriteLine("Enter num2");
            double num2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("sumation "+ Convert.ToDouble(num1+num2));
            Console.WriteLine("Subtraction " + Convert.ToDouble(num1-num2));
            Console.WriteLine("Division " + Convert.ToDouble(num1 / num2));
            Console.WriteLine("Multiplication " + Convert.ToDouble(num1 * num2));

        }
    }
}