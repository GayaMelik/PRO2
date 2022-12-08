// Задача 32  Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
//  Массивы к задачам 32 и 33 можно сделать рандомными. В задаче 33 на экран выводится ТОЛЬКО одно сообщение: либо "да", либо "нет".

int[] GetRandomArray(int size, int leftRange, int rightRange) // заполянет массив случайными числами 
{
    int[] array = new int[size];
    Random rand = new Random();

    for(int i = 0; i < array.Length; i++) //перебираем эелементы массива пока ни меньше длинны массива + счетчик 
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

const int SIZE = 12;             // парметры массива (длинна, левая и правая границы)
const int LEFTRANGE = -9;
const int RIGHTRANGE = 9;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE); // массив на 12 элементов со случайными значеними от -9 ло 9 

Console.WriteLine($"[{string.Join(", ", arr)}]");

 for (int i = 0; i < SIZE; i++)
 {
arr[i] = arr[i] *-1;  
 }
Console.WriteLine($"[{string.Join(", ", arr)}]");