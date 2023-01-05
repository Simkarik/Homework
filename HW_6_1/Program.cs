//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine($"Enter quantity of numbers you want to type in: ");
int num = int.Parse(Console.ReadLine());
int[] array = new int[num];

void GetMas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.WriteLine($"Enter number {i+1}: ");
        mas[i] = int.Parse(Console.ReadLine());
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

int PositiveQ (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) {sum++;} 
    }
    return sum;
}

GetMas(array);
PrintMass(array);

Console.WriteLine($"You entered {PositiveQ(array)} positive numbers.");