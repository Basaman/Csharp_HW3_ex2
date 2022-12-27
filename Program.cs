//Напишите программу, которая принимает на вход координаты двух точек и находит
//расстояние между ними в трехмерном пространстве

Console.Clear();
Console.Write("Введите X: ");
int X = int.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine());
Console.Write("Введите Z: ");
int Z = int.Parse(Console.ReadLine());

Console.Write("Введите X1: ");
int X1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
int Y1 = int.Parse(Console.ReadLine());
Console.Write("Введите Z1: ");
int Z1 = int.Parse(Console.ReadLine());

double distance = 0;

distance = Math.Sqrt(Math.Pow((X1 - X), 2) + Math.Pow((Y1 - Y), 2) + Math.Pow((Z1 - Z), 2));
distance = Math.Round(distance, 2);

Console.WriteLine($"A{(X, Y, Z)} B{(X1, Y1, Z1)} -> {distance}");

