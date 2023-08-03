// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

class Program
{
    static void Main()
    {
        double b1, k1, b2, k2;

        // Вводим значения от пользователя
        Console.Write("Введите значение b1: ");
        b1 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение k1: ");
        k1 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение b2: ");
        b2 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение k2: ");
        k2 = double.Parse(Console.ReadLine());

        // Находим точку пересечения
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        // Выводим результат
        Console.WriteLine("Точка пересечения прямых: ({0}; {1})", x, y);
    }
}
