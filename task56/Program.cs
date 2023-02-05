/* Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.Write("Введите размер массива (например:(3) ): ");
int num = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[num, num];
FillArrayRandomNumbers(arr);
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Массив: ");
PrintArray(arr);
int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Номер строки с наименьшей суммой элементов: " + (indexLine) + " строка");
Console.WriteLine("Сумма элементов = " + (minsum));
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