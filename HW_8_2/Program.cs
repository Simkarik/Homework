//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Enter number of rows: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number of columns: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Enter maximal posible number: ");
int max = int.Parse(Console.ReadLine());

int[,] table = new int[x,y];

void GetTable(int[,] tab, int mx, int m, int n)
{
for (int i = 0; i < m; i++)
{
    for (int t = 0; t < n; t++)
    {
        tab[i,t] = new Random().Next(1, mx+1);
    }
}
}

void PrintTable (int[,] tab, int m, int n)
{
for (int i = 0; i < m; i++)
{
    for (int t = 0; t < n; t++)
    {
        Console.Write($"{tab[i,t]} ");
    }
    Console.WriteLine();
}
}

void MinimalRowSum (int[,] tab, int m, int n)
{
    int min = 0; int minpos = 0;
for (int i = 0; i < m; i++)
{
    int sum = 0;
    for (int t = 0; t < n; t++)
    {
        sum = sum + tab[i,t];
        if (i == 0) min = sum;
    }
    if (sum <= min) 
    {
    min = sum;
    minpos = i + 1;
    }
}
    Console.WriteLine($"Row #{minpos} has lesser sum of elements");
}
GetTable(table, max, x, y);
PrintTable(table, x, y);
MinimalRowSum(table, x, y);