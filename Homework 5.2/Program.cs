namespace Homework_5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число: ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ви ввели число {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Це не число");
            }

        }
    }
}
