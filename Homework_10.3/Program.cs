namespace Homework_10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "один, два, три, чотири";

            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    result += input[i];
                }
            }
            Console.WriteLine("Результат: " + result);
        }
    }
}
