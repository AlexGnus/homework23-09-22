/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++) 
        
        {
            matrix[i,j] = new Random().Next(11); 
        }
    }
    return matrix;
}
void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++) 
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++) 
        {
            Console.Write(inputMatrix[i,m] + "\t"); 
        }
        Console.WriteLine();
    }
}
int[,] resultMatrix = GetMatrix(rows, columns); 


PrintMatrix(resultMatrix);

for (int j =0; j< columns; j++)
{
double sum = 0;
 for (int i = 0; i< rows; i++)
 {
    sum += resultMatrix[i,j];
 }

Console.Write(Math.Round((sum/rows),2) + "\t");
}