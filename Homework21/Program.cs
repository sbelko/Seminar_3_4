// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.Write("Введите координаты точки Xa: "); int Xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Ya: "); int Ya = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Za: "); int Za = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Xb: "); int Xb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Yb: "); int Yb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координаты точки Zb: "); int Zb = int.Parse(Console.ReadLine()!);
double x = Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2);
double len = Math.Sqrt(x);
Console.WriteLine (Math.Round(len, 2));
