// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.



int[,] GetTable( int mx, int m, int n)
{
    int[,] tab = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int t = 0; t < n; t++)
    {
        tab[i,t] = new Random().Next(1, mx+1);
    }
}
    return tab;
}

void PrintTable (int[,] tab)
{
for (int i = 0; i < tab.GetLength(0); i++)
{
    for (int t = 0; t < tab.GetLength(1); t++)
    {
        Console.Write($"{tab[i,t]} ");
    }
    Console.WriteLine();
}
}


int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}


int[,] firstMatrix = GetTable(5, 2, 2);
PrintTable(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = GetTable(10, 2, 2);
PrintTable(secondMatrix);
Console.WriteLine();
PrintTable(MultiplyMatrix(firstMatrix, secondMatrix));