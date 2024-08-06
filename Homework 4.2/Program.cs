Console.WriteLine("Enter the first number");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter operation +, -, *, /");
string operation = Console.ReadLine();

Console.WriteLine("Enter the second number");
double secondNumber = Convert.ToDouble(Console.ReadLine());

if (operation == "+")
{
    double addition = firstNumber + secondNumber;
    Console.WriteLine($"{firstNumber} + {secondNumber} = {addition}");
}
else if (operation == "-")
{
    double subtraction = firstNumber - secondNumber;
    Console.WriteLine($"{firstNumber} - {secondNumber} = {subtraction}");
}
else if (operation == "*")
{
    double multiplication = firstNumber * secondNumber;
    Console.WriteLine($"{firstNumber} * {secondNumber} = {multiplication}");
}
else if (operation == "/")
{
    if (secondNumber == 0)
    {
        Console.WriteLine("It is not possible to divide by 0");
    }
    else
    {
        double division = firstNumber / secondNumber;
        Console.WriteLine($"{firstNumber} / {secondNumber} = {division}");
    }

}

