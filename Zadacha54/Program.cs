// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void PrintArraySort(double[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            for (int k = 0; k < tab.GetLength(1) - 1; k++)
            {
                if (tab[i, k] < tab[i, k + 1])
                {
                    double temp = tab[i, k + 1];
                    tab[i, k + 1] = tab[i, k];
                    tab[i, k] = temp;
                }
            }
        }
    }
}

FillArray(table);
Console.WriteLine();
PrintArray(table);
Console.WriteLine();
PrintArraySort(table); 
PrintArray(table);