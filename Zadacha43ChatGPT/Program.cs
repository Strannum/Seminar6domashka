using System;
class Program
{   
    static void Main(string[] args)
    {
        Console.Clear();
        double k1, b1, k2, b2, x, y;
        Console.WriteLine("Введите значение k1 больше нуля: ");
        k1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение b1 больше нуля: ");
        b1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение k2 больше нуля: ");
        k2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение b2 больше нуля: ");
        b2 = double.Parse(Console.ReadLine());

        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;

        Console.WriteLine("Точка пересечения: ({0}, {1})", x, y);
        Console.WriteLine("Для выхода из программы нажмите q");
        Console.ReadKey();
    }
}
