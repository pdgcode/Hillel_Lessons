namespace Homework_11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char[] word = { 'с', 'о', 'б', 'а', 'к', 'а' };
            int attempt = word.Length;
            char[] guessedWord = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                guessedWord[i] = '_';
            }
            Console.WriteLine($"Вітаємо! Спробуйте вгадати зашифроване слово!");
            Console.WriteLine($"Кількість літер у слові: {attempt}");
            Console.WriteLine($"Кількість можливих невірних спроб: {attempt}");

            while (attempt > 0)
            {
                bool isCorrect = false;

                Console.Write("Введіть вашу літеру: ");
                char guess = Convert.ToChar(Console.ReadLine());


                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == guess && guessedWord[i] == '_')
                    {
                        guessedWord[i] = guess;
                        isCorrect = true;
                        Console.WriteLine($"Ви вгадали літеру. Її позиція у слові: {i + 1}");
                    }
                }

                if (!isCorrect)
                {
                    attempt--;
                    Console.WriteLine($"Такої літери немає! Залишилось спроб: {attempt}");
                }

                bool isWordGuessed = true;
                for (int i = 0; i < guessedWord.Length; i++)
                {
                    if (guessedWord[i] == '_')
                    {
                        isWordGuessed = false;
                        break;
                    }
                }

                if (isWordGuessed)
                {
                    Console.WriteLine("Вітаємо, ви вгадали слово!");
                    break;
                }
            }

            if (attempt == 0)
            {
                Console.WriteLine("Ви програли!");
            }
        }
    }
}
