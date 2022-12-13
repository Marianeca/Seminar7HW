// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int m, n;

Console.WriteLine($"Введите m размерность массива: ");
int.TryParse(Console.ReadLine()!, out m);
Console.WriteLine($"Введите n размерность массива: ");
int.TryParse(Console.ReadLine()!, out n);

double[,] array = new double[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Math.Round(new Random().NextDouble() * 19.0 - 9, 1);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}


