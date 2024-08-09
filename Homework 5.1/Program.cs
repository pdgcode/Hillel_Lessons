using System.Threading.Channels;

namespace Homework_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Введіть перше число");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть друге число");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            try
            {
                sum = firstNumber / secondNumber;
                Console.WriteLine($"{firstNumber} / {secondNumber} = {sum}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Не можна поділити на нуль");
                   
            }


        }
    }
}
