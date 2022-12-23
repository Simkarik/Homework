// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine();
int i = 1;
while(i <= num-1)
{
    Console.Write($"{Math.Pow(i,3)}, "); //или Console.WriteLine(i*i*i);
    i++;
}
    Console.Write($"{Math.Pow(i,3)}"); //просто для красоты
