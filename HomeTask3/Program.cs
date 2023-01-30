/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным. 
6 -> да 7 -> да 1 -> нет */


int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void CheckDay(int number)
{
    if (number < 1 || number > 7)
        Console.WriteLine("Введенное число не является днем недели.");
    else
        if (number == 6 || number == 7)
        Console.WriteLine("Выходной");
    else Console.WriteLine("День не является выходным");
}

int number = GetNumber("Введите цифру от 1 до 7");

CheckDay(number);



