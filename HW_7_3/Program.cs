// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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

void Avg (int[,] tab, int m, int n)
{
    Console.WriteLine("Average of each row: ");
    double avg;
    for (int i = 0; i < n; i++)
{
    avg = 0;
    for (int t = 0; t < m; t++)
    {
        avg = avg + tab[t,i];
    }
    Console.Write($"{avg/m}  ");
}
    Console.WriteLine();
}

GetTable(table, max, x, y);
PrintTable(table, x, y);
Avg(table, x, y);