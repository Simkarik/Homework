//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Enter number of rows: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number of columns: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Enter minimal possible number: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Enter maximal posible number: ");
int max = int.Parse(Console.ReadLine());

double[,] table = new double[x,y];

void GetTable(double[,] tab, int mn, int mx, int m, int n)
{
for (int i = 0; i < m; i++)
{
    for (int t = 0; t < n; t++)
    {
        double a = new Random().Next(0,100) * 0.01;
        tab[i,t] = new Random().Next(mn, mx+1) + a;
    }
}
}

void PrintTable (double[,] tab, int m, int n)
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

GetTable(table, min, max, x, y);
PrintTable(table, x, y);