//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Enter number of rows: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number of columns: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Enter minimal possible number: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Enter maximal posible number: ");
int max = int.Parse(Console.ReadLine());

double[,] table = new double[m,n];

void GetTable(double[,] tab, int mn, int mx)
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

void PrintTable (double[,] tab)
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

void SearchTable(double[,] tab, int x, int y)
{
    Console.WriteLine("Enter number of a row: ");
int m = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter number of a column: ");
int n = int.Parse(Console.ReadLine());
    if (m >x || n>y)
    { Console.WriteLine("Error. Trying to search out of bounds"); }
    else if (tab[m,n] != 0)
    {Console.WriteLine($"This is the element [{m},{n}] - {tab[m-1,n-1]}");}
    else {Console.WriteLine($"This element is a zero or was not assinged");}
}

SearchTable(table, m, n);
GetTable(table, min, max);
PrintTable(table);