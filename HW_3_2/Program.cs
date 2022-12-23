// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите первую координату точки А: "); 
int a1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату точки А: "); 
int a2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третью координату точки А: "); 
int a3 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите первую координату точки B: "); 
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую координату точки B: "); 
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третью координату точки B: "); 
int b3 = int.Parse(Console.ReadLine());

double a = Math.Sqrt((b1-a1)*(b1-a1)+(b2-a2)*(b2-a2)+(b3-a3)*(b3-a3)); //или вместо Math.Sqrt, не используя доп библиотеки можно разложить по формуле квадратного корня
Console.WriteLine(a);