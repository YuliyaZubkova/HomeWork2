// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа

Random rnd = new Random();
int number = rnd.Next(100, 1000); //[100, 1000]
int firstDigit = number / 100;
int secondDigit = number % 10;

Console.WriteLine(firstDigit, secondDigit);


/* if(firstDigit > secondDigit)
        Console.WriteLine($"Число {firstDigit} больше чем {secondDigit}");
else if (secondDigit > firstDigit)
        Console.WriteLine($"Число {secondDigit} больше чем {firstDigit}");
else 
        Console.WriteLine("Числа равны");