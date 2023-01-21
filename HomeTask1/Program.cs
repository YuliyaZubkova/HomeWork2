/* Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. 
456 -> 5 
782 -> 8 
*/

Console.WriteLine("Введите трехзначное число: ");
string number1 = Console.ReadLine();
int number = Convert.ToInt32(number1);

Console.Write(number);
Console.Write(" -> ");

if (number < 1000 && number >100)
    {
    int firstDigit = number % 100;
    int secondDigit = firstDigit/10;
    Console.Write(secondDigit);
}
else  Console.Write("Введенное число не трехзначное - введите трехзначное число.");


