//Двумерные массивы
// Закрасить картинку 

// string[,]table = new string[2,3]; // первая цифра строки, вторая столбцы, table - наименование массива
// string - тип данных/ запятая это мерности. Одна - строки, 2 - столбцы.Это прямоугольная таблица чисел - матрица 

string[,]table = new string[2,5];
table [1, 2] = "слово"; //индексы меняются от нуля 
// table [0,0]  table [0,1]  table [0,2]  table [0,3]  table [0,4]  меняется индекс столбца 
// table [1,0]  table [1,0]  table [2,0]  table [3,0]  table [4,0]  меняется индекс столбца 

// for (int rows = 0; rows < 2; rows++) // rowsпеременная индекса 
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
// Console.WriteLine($"-{table[rows,columns]}-");

//     }
// }

// int [,] matrix = new int [1,4];

// for (int i = 0; i < 3; i++) // i строки
// {
//     for (int j = 0; j < 4; j++) // j - стобцы
//     {
// Console.Write($"-{matrix[i,j]} ");

//     }
//     Console.WriteLine (); // принудительный переход на нову строку 
// 
 
void PrintArray (int[,] matrix)     // метод для заполнения двухмерной матрицы

{

    for (int i = 0; i < matrix.GetLength(0); i++) // i строки
   { 
        for (int j = 0; j < matrix.GetLength(1); j++) // j - стобцы
              {
                 Console.Write($"-{matrix[i,j]} ");

              }
                  Console.WriteLine (); // принудительный переход на нову строку 
   }
}
void FillArray (int[,] matrix)   
int [,] matrix = new int [1,4];
PrintArray(matrix);
