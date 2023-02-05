/* Задача 54: Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Введите количество строк: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[num1, num2];
FillArrayRandomNumbers(arr);
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Массив: ");
PrintArray(arr);

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int k = 0; k < arr.GetLength(1) - 1; k++)
        {
            if (arr[i, k] < arr[i, k + 1])
            {
                int temp = 0;
                temp = arr[i, k];
                arr[i, k] = arr[i, k + 1];
                arr[i, k + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(arr);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}