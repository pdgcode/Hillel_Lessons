namespace Hillel_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int zero = 0;
                int k = 5 / zero;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Неможливо поділити на нуль");
            }
        }
    }
}
