// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: "); 
int num = int.Parse(Console.ReadLine());
int[] array = new int[5];
int n;
for (int i = 0; i < 5; i ++)
{
    n = num%10;
    array[i] = n;                                    //в решении без массива прищлось бы задавать 5 отдельных переменных
    num = num/10;                                    //и уже в них хранить цифры, так компактнее)
}
if(array[4] == array[0] && array[3] == array[1])
{
    Console.WriteLine("Это полиндром");
}
else
{
    Console.WriteLine("Это не полиндром");
}
