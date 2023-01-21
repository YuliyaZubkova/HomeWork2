/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет. 
645 -> 5
78 -> третьей цифры нет 
32679 -> 6
*/

Console.WriteLine("Введите число: ");
string number1 = Console.ReadLine();
int number = Convert.ToInt32(number1);
int count = number.ToString().Length;


