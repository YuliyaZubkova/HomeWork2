// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
string number1 = Console.ReadLine();
int numberOne = Convert.ToInt32(number1);

Console.WriteLine("Введите второе число: ");
string number2 = Console.ReadLine();
int numberTwo = Convert.ToInt32(number2);

Console.Write(numberOne+", "+numberTwo+" -> ");

if (numberOne % numberTwo == 0)
    Console.WriteLine("кратно");
else Console.WriteLine("не кратно"+" остаток "+numberOne%numberTwo);
