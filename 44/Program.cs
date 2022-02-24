// 44. Найти точку пересечения двух прямых 
// заданных уравнением y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы
Console.WriteLine("Введите b1");
int b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k1");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2");
int b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2");
int k2 = int.Parse(Console.ReadLine());
int x = (b2-b1)/(k1-k2);
int y = k1*x+b1;
Console.WriteLine($"точка пересечения имеет координаты ({x},{y})");