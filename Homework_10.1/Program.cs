namespace Homework_10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string input = "Pierre Polnareff";

            int spaceIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    spaceIndex = i;
                    break;
                }
            }
            char firstLetterOfFirstName = input[0];
            char firstLetterOfLastName = input[spaceIndex + 1];

            if (firstLetterOfFirstName == firstLetterOfLastName)
            {
                Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
            }
            else
            {
                Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
            }
        }
    }
}
