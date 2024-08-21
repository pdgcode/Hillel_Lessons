namespace Homework_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("-----------------Task 1-----------------");
            int[] array = new int[10];
            int sum = 0;
            Random random = new Random();


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-10, 10);
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Індекс: {i}, значення: {array[i]}");
                }
                sum += array[i];
            }
            Console.WriteLine("-----------------Task 2-----------------");
            Console.WriteLine(sum < 0 ? "Сума елементів масиву від'ємна" : "Сума елементів масиву додатня");

            Console.WriteLine("-----------------Task 3-----------------");




            int[,] multiplicationTable = new int[9, 9];
            Console.WriteLine("Добутки таблиці множення: ");
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    multiplicationTable[i, j] = (i + 1) * (j + 1);
                    Console.Write(multiplicationTable[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("-----------------Task 4-----------------");




            int[,] minMaxArray = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    minMaxArray[i, j] = random.Next(1, 50);
                    Console.Write(minMaxArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int min = minMaxArray[0, 0];
            int max = minMaxArray[0, 0];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (minMaxArray[i, j] > max)
                    {
                        max = minMaxArray[i, j];

                    }
                    if (minMaxArray[i, j] < min)
                    {
                        min = minMaxArray[i, j];

                    }
                }

            }
            Console.WriteLine("Максимальне значення: " + max);
            Console.WriteLine("Мінімальне значення: " + min);
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (minMaxArray[i, j] == min)
                    {
                        Console.WriteLine($"Координати мінімального: {i + 1}, {j + 1}");
                    }
                    if (minMaxArray[i, j] == max)
                    {
                        Console.WriteLine($"Координати максимального: {i + 1}, {j + 1}");
                    }
                }
            }
        }
    }
}

