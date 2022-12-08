// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// ​
// 645 -> 5
// ​
// 78 -> третьей цифры нет
// ​
// 32679 -> 6

Console.WriteLine("введите любое число");
int number = Convert.ToInt32(Console.ReadLine());
int rez = 0;
if (number < 99)
Console.WriteLine("Третьей цифры нет");
else
rez = (number % 100)/10;
Console.WriteLine($"Третья цифра = {rez}");

