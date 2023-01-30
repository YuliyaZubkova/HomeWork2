// Напишите программу, 
//которая выводит случайное трехзначное число 
//и удаляет вторую цифру этого числа

Random rnd = new Random();
int number = rnd.Next(100, 1000); //[100, 1000]
Console.Write(number);
Console.Write(" -> ");
int firstDigit = number / 100;
int secondDigit = number % 10;

Console.Write(firstDigit);
Console.Write(secondDigit);




