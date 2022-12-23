// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру обозначающую день недели: "); 
int num = int.Parse(Console.ReadLine());

if(num > 0 && num < 8)
{
if(num == 6 || num == 7)
{
    Console.WriteLine("Это выходной! :)");
}
else
{
    Console.WriteLine("Это будний. :(");
}
}
else
{
    Console.WriteLine("Что-то ввели не так.");
}
