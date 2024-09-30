namespace Homework_16._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть шлях до вихідного файлу: ");
            string startDoc = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Введіть шлях до файлу, в який будуть скопійовані дані: ");
            string finishDoc = Console.ReadLine();
            Console.WriteLine();

            using (StreamReader sr = new StreamReader(startDoc))
            {

                using (StreamWriter sw = new StreamWriter(finishDoc))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(line);

                    }
                    Console.WriteLine("Файл успішно скопійовано");
                }
            }
        }
    }
}
