//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void FillMass(int[] mas)
{
    int i = 0;
    while (i < mas.Length)
    {
        mas[i] = new Random().Next(1, 1000);
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
    Console.WriteLine();
}

int EvenCount(int[] arr)
{
    int i = 0;
    int sum = 0;
    while (i < arr.Length)
    {
        if(arr[i]%2 == 0)
        {
            sum++;
        }
        i++;
    }
    return sum;
}

Console.WriteLine("Введите размер массива: ");
int s = int.Parse(Console.ReadLine());

int[] array = new int[s];

Console.WriteLine("Сгенерированный массив: ");
FillMass(array);
PrintMass(array);

int result = EvenCount(array);
Console.WriteLine($"Количество чётных чисел в массиве = {result}");