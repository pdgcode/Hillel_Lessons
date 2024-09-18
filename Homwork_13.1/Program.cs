using System.Text;

namespace Homwork_10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            StringBuilder stringBuilder = new StringBuilder();

            Console.Write("Введіть заголовок: ");
            string title = Console.ReadLine();
            stringBuilder.AppendLine(title);
            stringBuilder.AppendLine();
            Console.Write("Введіть кількість подій: ");
            int events = int.Parse(Console.ReadLine());
            for (int i = 1; i <= events; i++)
            {
                Console.Write($"Введіть подію {i}: ");
                string ev = Console.ReadLine();
                stringBuilder.Append($"{i}. ");
                stringBuilder.AppendLine(ev);
            }
            string data = DateTime.Today.ToShortDateString();
            stringBuilder.AppendLine(data);
            Console.Clear();
            string result = stringBuilder.ToString();
            Console.Write(result);
        }
    }
}
