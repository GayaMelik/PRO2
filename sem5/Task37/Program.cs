// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



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

const int SIZE = 5;             // парметры массива (длинна, левая и правая границы)
const int LEFTRANGE = 1;
const int RIGHTRANGE = 9;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);  // создали новую переменную

Console.WriteLine(string.Join(", ", arr)); // вывести исходный массив

int[] RezaltArray = new int[arr.Length / 2 + arr.Length % 2]; //создаем массив и проверяем его на четность



for (int i = 0; i < arr.Length / 2 ; i++) 
{
 RezaltArray [i] = arr[i]*arr[arr.Length - 1 - i];
}

if(arr.Length % 2 == 1) //проверка на четность
{

 RezaltArray [RezaltArray.Length-1] = arr [arr.Length/2];
 
}

Console.WriteLine(string.Join(", ",RezaltArray));






