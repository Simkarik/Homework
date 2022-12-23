// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.WriteLine("Первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Второе число: ");
int b = int.Parse(Console.ReadLine());

int Power(int numA, int numB)
{
    int result = numA;
    for(int i = 0; i < numB; i++)
    {
        result *= numA;
    }
    return result;
}
int c = Power(a,b);
Console.WriteLine($"Число {a} в степени {b} = {c}");