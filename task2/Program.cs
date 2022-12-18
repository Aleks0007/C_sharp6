/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Write("Введите значение b1: ");
double num1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите число k1: ");
double num2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите значение b2: ");
double num3 = double.Parse(Console.ReadLine()!);
Console.Write("Введите число k2: ");
double num4 = double.Parse(Console.ReadLine()!);

GetIntersectionDot(num1, num2, num3, num4);

void GetIntersectionDot(double b1, double k1, double b2, double k2)
{
    double x = Math.Round((-b2 + b1)/(-k1 + k2), 1);
    double y = Math.Round(k2 * x + b2, 1);

    Console.WriteLine($"Точка пересечения двух прямых имеет координаты x: {x} | y: {y}");
}
