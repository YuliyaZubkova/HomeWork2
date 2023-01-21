/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
● 14 -> нет
● 46 -> нет
● 161 -> да */

Console.WriteLine("Введите число: ");
string number1 = Console.ReadLine();
int numberOne = Convert.ToInt32(number1);

Console.Write(numberOne+" -> ");

if (numberOne % (7*23) == 0)
    Console.WriteLine("да");
else Console.WriteLine("нет");

