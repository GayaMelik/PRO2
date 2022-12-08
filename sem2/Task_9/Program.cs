// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random ().Next(10, 100);
Console.WriteLine(number);

int digit2 = number % 10; // находим второе число через остаток от деления %
int digit1 = number / 10; // находим первое число черезе деление на 10, учитывая что наше число всегда двузначное 

Console.WriteLine($"Первая цифра = {digit1}, вторая цифра = {digit2}");
int number4 = 2;
if (digit1 > digit2)
{
    Console.WriteLine(digit1);
}
else
{
    Console.WriteLine(digit2);
}
