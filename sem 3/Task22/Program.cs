// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

int pow = 1;
for (int i = 1; i <= n; i++)
{
    pow = i * i;
    Console.WriteLine($"{i}^2 ={pow}");
}
