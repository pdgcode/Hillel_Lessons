namespace Homework_12._1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введіть порядок числа Фібоначчі: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci.CalculationFibonacci(num));
        }
    }

    public static class Fibonacci
    {
        public static int CalculationFibonacci(int a)
        {
            if (a < 2)
            {
                return a;
            }
            else
            {
                return CalculationFibonacci(a - 1) + CalculationFibonacci(a - 2);
            }
        }
    }
}
