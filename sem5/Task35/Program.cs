// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
// Диапазон от 0 до 150


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

const int SIZE = 123;             // парметры массива (длинна, левая и правая границы)
const int LEFTRANGE = 0;
const int RIGHTRANGE = 150;

int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE); //вызов метода

Console.WriteLine(string.Join(", ", arr)); // вывести исходный массив
int rez = 0;

for(int i = 0; i < arr.Length; i++){

    if (arr[i] <= 99 && arr[i] >=10)
    {
        rez ++;
    }

} 

Console.WriteLine(rez);


