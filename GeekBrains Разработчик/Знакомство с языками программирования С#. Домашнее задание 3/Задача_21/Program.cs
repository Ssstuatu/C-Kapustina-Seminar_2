// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double Lenght(int x1, int y1, int z1, int x2, int y2, int z2)
{
int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

    double distance = Math.Sqrt(A * A + B * B + C * C);
    return distance;
}
int GetInfo (string message)
{
    Console.Write(message);
    int x = Convert.ToInt32(Console.ReadLine());
    return x;
}

int x1 = GetInfo("Введите координату X 1 точки: ");
int y1 = GetInfo("Введите координату Y 1 точки: ");
int z1 = GetInfo("Введите координату Z 1 точки: ");
int x2 = GetInfo("Введите координату X 2 точки: ");
int y2 = GetInfo("Введите координату Y 2 точки: ");
int z2 = GetInfo("Введите координату Z 2 точки: "); 

Console.WriteLine($"Расстояние между тремя точками на плоскости равно {Lenght(x1, y1, z1, x2, y2, z2)}");