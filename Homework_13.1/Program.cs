using System.Text;

namespace Hillel_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<string> toDoList = new List<string>();


            Add(toDoList);
            Vieuw(toDoList);
            Mark(toDoList);
            Remove(toDoList);
            Vieuw(toDoList);
        }

        static void Add(List<string> toDoList)
        {
            Console.WriteLine("Скільки справ хочете додати?");
            int value = int.Parse(Console.ReadLine());
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine($"Введіть назву справи {i + 1}");
                toDoList.Add(Console.ReadLine());
            }
        }

        static void Vieuw(List<string> toDoList)
        {
            Console.WriteLine("Ваші справи!");
            Console.WriteLine();
            for (int i = 0; i < toDoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {toDoList[i]}");
            }
        }

        static void Mark(List<string> toDoList)
        {
            Console.WriteLine("Яку справу ви вже зробили?");
            int num = int.Parse(Console.ReadLine());
            toDoList[num - 1] = $"V {toDoList[num - 1]}";
            Console.Clear();
            Vieuw(toDoList);
        }
        static void Remove(List<string> toDoList)
        {
            Console.WriteLine("Введіть номер справи для видалення");
            int i = Convert.ToInt32(Console.ReadLine());
            toDoList.RemoveAt(i - 1);
        }

    }

}