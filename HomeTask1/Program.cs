/* Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

//Console.WriteLine("Введите трехзначное число: ");
//int number = Convert.ToInt32(Console.ReadLine());

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void SecondNumber(int numberOne)
{
if (numberOne < 1000 && numberOne >100)
    {
    int firstDigit = numberOne % 100;
    int secondDigit = firstDigit/10;
    Console.Write($"Вторая цифра числа {numberOne} -> {secondDigit} ");
}
else  Console.Write("Введенное число не трехзначное - введите трехзначное число.");
}

int numberOne = GetNumber("Введите трехзначное число: ");
SecondNumber(numberOne);

