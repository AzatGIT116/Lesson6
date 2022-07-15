/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. */

Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());

Check(b1, k1, b2, k2);
void Check(double b1, double k1, double b2, double k2)
{
    if (k1  - k2 == 0)
    {
        Console.WriteLine("Прямые параллельны");
    }
    else
    {
        var x = (b2 - b1) / (k1 - k2);
        var y = k1 * x + b1;
        Console.WriteLine($"Пересечение в точке: ({x};{y})");
    }
}