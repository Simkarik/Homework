// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (На самом деле просто тест на внимательность к лекциям:) )
void FillMass(int[] mas)
{
    int i = 0;
    while (i < mas.Length)
    {
        mas[i] = new Random().Next(1, 100); 
        i++;
    }
}

void PrintMass(int[] mass)
{
    int pos = 0;
    while (pos< mass.Length -1)
    {
        Console.Write($"{mass[pos]}, ");
        pos++;
    }
    Console.Write(mass[pos]);
}

int[] array = new int[8]; //вместо метода для точного соблюдения условий задачи можно было использовать int[] array = {3, 12, 53, 66, 23, 16, 98, 76};

FillMass(array);
PrintMass(array);