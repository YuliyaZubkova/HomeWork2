// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

Random rnd = new Random();
int number = rnd.Next(10, 100); //[10, 100]
int firstDigit = number / 10;
int secondDigit = number % 10;

if(firstDigit > secondDigit)
        Console.WriteLine($"Число {firstDigit} больше чем {secondDigit}");
else if (secondDigit > firstDigit)
        Console.WriteLine($"Число {secondDigit} больше чем {firstDigit}");
else 
        Console.WriteLine("Числа равны");
