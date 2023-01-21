/* Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
● 5, 25 -> да ● -4, 16 -> да ● 25, 5 -> да ● 8,9 -> нет */

Console.WriteLine("Введите первое число: ");
string number1 = Console.ReadLine();
int numberOne = Convert.ToInt32(number1);

Console.WriteLine("Введите второе число: ");
string number2 = Console.ReadLine();
int numberTwo = Convert.ToInt32(number2);

if (numberOne*numberOne == numberTwo)
    Console.WriteLine(" -> Да");
else 
    if (numberTwo*numberTwo == numberOne)
        Console.WriteLine(" -> Да");
    else Console.WriteLine(" -> Нет");
