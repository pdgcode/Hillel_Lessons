namespace Homework_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("------------- Task 1 -------------");
            try
            {

                int numberOfEmployees;
                int salary = 0;
                double average;
                Console.Write("Введіть кількість працівників: ");
                numberOfEmployees = Convert.ToInt32(Console.ReadLine());
                if (numberOfEmployees <= 0)
                {
                    Console.WriteLine("Працівників повинно бути більше ніж 1");

                }
                else
                {
                    for (int i = 1; i <= numberOfEmployees; i++)
                    {
                        Console.Write($"Введіть зарплату працівника {i}: ");
                        salary += Convert.ToInt32(Console.ReadLine());
                    }
                    average = salary / numberOfEmployees;
                    Console.WriteLine($"Середня зарплата {numberOfEmployees} працівників складає {average} гривень");
                }


            }
            catch (Exception)
            {
                Console.WriteLine("Неправильний ввід");
            }
            Console.WriteLine("------------- Task 2 -------------");
            try
            {
                Console.Write("Введіть кількість рядків графіку: ");
                int rows = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Неправильний ввід");
            }
            Console.WriteLine("------------- Task 3 -------------");
            try
            {
                Console.Write("Введіть число до якого вивести прості числа: ");
                int number = Convert.ToInt32(Console.ReadLine());


                if (number <= 1)
                {
                    Console.WriteLine("Число 1 і менше не належать ні до простих, ні до складених чисел");
                }
                else
                {
                    for (int i = 2; i < number; i++)
                    {
                        bool isPrime = true;

                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }

                        if (isPrime)
                        {
                            Console.Write(i + " ");
                        }
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Неправильний ввід");
            }
            Console.WriteLine();
            Console.WriteLine("------------- Task 5 -------------");
            try
            {
                Console.Write("Вивести чисел Фібоначчі:  ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("Кількість повинна бути більше 0.");
                }
                else
                {
                    int a = 0;
                    int b = 1;
                    Console.Write($"{a} {b} ");
                    for (int i = 2; i < n; i++)
                    {
                        int c = a + b;
                        Console.Write(c + " ");
                        a = b;
                        b = c;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Неправильний ввід");
            }
            Console.WriteLine();
            Console.WriteLine("------------- Task 6 -------------");
            try
            {
                Console.Write("Введіть кількість годин: ");
                int hours = Convert.ToInt32(Console.ReadLine());
                if (hours > 24)
                {
                    Console.WriteLine("В дні не може бути більше ніж 24 години");

                }
                else if (hours <= 0)
                {
                    Console.WriteLine("Число повинне бути більше нуля");

                }
                else
                {
                    Console.Write("Введіть розмір годинної ставки: ");
                    double hourlyRate = Convert.ToDouble(Console.ReadLine());

                    double dailyPay = hours * hourlyRate;
                    Console.WriteLine($"Оплата за день: {dailyPay}");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Неправильний ввід");
            }
            Console.WriteLine("------------- Task 7 -------------");
            try
            {
                Console.WriteLine("для якого числа вивести табличку множення? ");
                int number = Convert.ToInt32(Console.ReadLine());
                
                    for (int i = 1; i <= 10; i++)
                    {
                        int sum = number * i;
                        Console.WriteLine($"{number} * {i} = {sum}");
                    }
                
            }
            catch (Exception)
            {
                Console.WriteLine("Неправильний ввід");
            }
            Console.WriteLine("------------- Task 8 -------------");
            try
            {
                Console.Write("Введіть число для перевірки на простоту: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number <= 1)
                {
                    Console.WriteLine("Число 1 і менше не належить ні до простих, ні до складених чисел");
                }
                else
                {
                    bool isPrime = true;

                    for (int i = 2; i < number; i++)
                    {
                        if (number % i != 0)
                        {
                            isPrime = true;
                        }
                        else
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        Console.WriteLine("Число просте");
                    }
                    else
                    {
                        Console.WriteLine("Число не є простим");
                    }
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Неправильний ввід");
            }
        }
    }
}
