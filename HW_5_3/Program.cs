//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void FillMass(float[] mas)
{
    int i = 0;
    while (i < mas.Length)
    {
        mas[i] = new Random().Next(1, 100);
        i++;
    }
}

void PrintMass(float[] mass)
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

float MaxMin(float[] arr)
{
    int i = 0;
    float min = arr[0];
    float max = arr[0];
    while (i < arr.Length)
    {
        if(arr[i] < min)
        {
            min = arr[i];
        }
        if(arr[i] > max)
        {
            max = arr[i];
        }
        i++;
    }
    float sum = max - min;
    return sum;
}

Console.WriteLine("Введите размер массива: ");
int s = int.Parse(Console.ReadLine());

float[] array = new float[s];

Console.WriteLine("Сгенерированный массив: ");
FillMass(array);
PrintMass(array);

float result = MaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом= {result}");