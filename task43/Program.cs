// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToDouble(Console.ReadLine());

GetPoint(b1, k1, b2, k2);

void GetPoint(double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    Console.Write($"({x},{y})");
}
else
{
    if (k1 == 0 && k2 == 0)
    {
        Console.WriteLine("прямые не пересекаются");
    }
    else Console.WriteLine("прямые не пересекаются");
}
}