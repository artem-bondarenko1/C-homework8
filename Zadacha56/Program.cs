// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Write("Введите количество строк:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов:  ");
int colums = Convert.ToInt32(Console.ReadLine());
double[,] table = new double[rows, colums];

void PrintArray(double[,] tab)
{
    for (int rows = 0; rows < tab.GetLength(0); rows++) 
    {
        for (int colums = 0; colums < tab.GetLength(1); colums++)
        {
            Console.Write($"{tab[rows, colums],4} ");
        }
        Console.WriteLine();
    }
}

void FillArray(double[,] tab)
{
    for (int rows = 0; rows < tab.GetLength(0); rows++)
    {
        for (int colums = 0; colums < tab.GetLength(1); colums++)
        {
            tab[rows, colums] = Convert.ToDouble(new Random().Next(1, 10));
        }
    }
}

void PrintArrayMinSum(double[,] tab)
{
    double minRow = 0;
    double minSumRow = 0;
    double sumRow = 0;
    for (int i = 0; i < tab.GetLength(1); i++)
    {
        minRow += tab[0, i];
    }
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++) sumRow += tab[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"{minSumRow + 1, 4} строка с наименьшей суммой элементов");
}

FillArray(table);
Console.WriteLine(); 
PrintArray(table);
Console.WriteLine();
PrintArrayMinSum(table); 