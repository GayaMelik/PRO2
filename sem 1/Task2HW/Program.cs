// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine ("Введите первое число А:");
int max = 0;
int min = 0;
int numberA= Convert.ToInt32(Console.ReadLine ()); // конвертация строки в  число

Console.WriteLine ("Введите второе число В:");

int numberB= Convert.ToInt32(Console.ReadLine ()); // конвертация строки в  число


if (numberA > numberB)
{
max = numberA;
min = numberB;
Console.WriteLine ("максимально число=" +max);
Console.WriteLine ("минимальное число=" +min);
}
else
{
min = numberA;
max = numberB;
Console.WriteLine ("максимально число=" +max);
Console.WriteLine ("минимальное число=" +min);
}



                 