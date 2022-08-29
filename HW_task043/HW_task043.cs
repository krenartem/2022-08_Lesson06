// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем. 
Console.Clear();
Console.WriteLine("Уравнение первой прямой: y = k1 * x + b1");
Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Уравнение первой прямой: y = k2 * x + b2");
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = (k1 * x + b1);
double y1 = (k2 * x + b2);
Console.WriteLine($"точка пересечения прямых: x={Math.Round(x, 2)}, y={Math.Round(y, 2)}, проверка y1={Math.Round(y1, 2)}");