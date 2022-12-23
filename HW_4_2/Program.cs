// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Введите число: "); 
int num = int.Parse(Console.ReadLine());

int NumSum(int n)
{
int sum = 0;
    while(n >= 1)
    {
        sum += n%10;
         n = n/10;
    }
return sum;
}
    int s = NumSum(num);
    Console.WriteLine($"Сумма цифр в числе - {s}");
