namespace Homework_9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Task 1------------");
            int[] array = { 12, 35, 1, 10, 34, 1 };
            int n = array.Length;

            int firstMax = array[0];
            int secondMax = array[0];

            for (int i = 1; i < n; i++)
            {
                if (array[i] > firstMax)
                {
                    firstMax = array[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (array[i] < firstMax && array[i] > secondMax)
                {
                    secondMax = array[i];
                }
            }

            Console.WriteLine("Другий найбільший елемент масиву: " + secondMax);
            Console.WriteLine("------------Task 2------------");
            //Не придумав як зробити
            Console.WriteLine("------------Task 3------------");
            //Не придумав як зробити
            Console.WriteLine("------------Task 4------------");

            int[,] array2 = {
            { 5, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 5 }
        };

            int n2 = array2.GetLength(0);
            int sum = 0;

            for (int i = 0; i < n2; i++)
            {
                sum += array2[i, i];
            }

            Console.WriteLine("Сума елементів діагоналі: " + sum);
        }
    }
}
