// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] array = new int[4, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

int a, b;
Console.WriteLine($"Введите позицию элемента по вертикали: ");
int.TryParse(Console.ReadLine()!, out a);
Console.WriteLine($"Введите позицию элемента по горизонтали: ");
int.TryParse(Console.ReadLine()!, out b);

if (a < array.GetLength(0) && b < array.GetLength(1))
    Console.WriteLine($"{array.GetValue(a, b)}");
else
{
    Console.WriteLine($"такого числа в массиве нет");
}