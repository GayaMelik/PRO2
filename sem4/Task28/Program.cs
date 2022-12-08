// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.								
// 4 -> 24								
// 5 -> 120								


    				
Console.WriteLine("Введите чило");
int number = Convert.ToInt32(Console.ReadLine());


int res = 1;
int n = 1; // n - счетчик

while (number >= n)
{
res = n * res;
n++;

}
Console.WriteLine(res);
 
