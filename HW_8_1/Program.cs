//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

void SortTable (int[,] tab, int m, int n)
{
for (int i = 0; i < m; i++)
{
    for (int count = 0; count < n; count++)
    {
        int max = 0;
        int maxpos = 0;
    for (int t = count; t < n; t++)
    {
        if (tab[i,t] > max) 
        {
            max = tab[i,t]; 
            maxpos = t;
        } 
    }
      tab[i,maxpos] = tab[i,count];  
      tab[i,count] = max;
    }
}
}

GetTable(table, max, x, y);
PrintTable(table, x, y);
SortTable(table, x, y);
Console.WriteLine();
PrintTable(table, x, y);