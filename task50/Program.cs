/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    
    {
        array[i, j] = new Random().Next(10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
      
}
Console.Write("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());
if (rows < array.GetLength(0) && columns < array.GetLength(1))

        Console.WriteLine($"Элементом с индексом [{rows},{columns}] является: {array[rows, columns]} ");
    else Console.WriteLine($" элемента с индексом [{rows},{columns}] нет в массиве");
