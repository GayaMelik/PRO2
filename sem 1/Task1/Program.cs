// Напишите программу которая на вход принимает два числа и проверяте, является ли первое квадратом  второго.
// а = 25, b = 5 -> да
// a = 2, b = 10  -> нет
// a = 9, b =  -3 -> да
// ф = -3, b = 9 -> ytn

Console.WriteLine ("Введите  число А:");

int numberA= Convert.ToInt32(Console.ReadLine ()); // конвертация строки в  число

Console.WriteLine ("Введите  число В:");

int numberB= Convert.ToInt32(Console.ReadLine ()); // конвертация строки в  число

if (numberA == numberB*numberB)
{
Console.WriteLine ("Yes");
}
else
{
Console.WriteLine("No");
}