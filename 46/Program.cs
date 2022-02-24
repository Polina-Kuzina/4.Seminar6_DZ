// 46. Написать программу масштабирования фигуры
Console.WriteLine("Задайте координаты фигуры (x,y) через пробел");
var str = Console.ReadLine()
                  .Replace("(", "")
                  .Replace(")", "")
                  .Replace(",", " ")
                  .Split(" ")
                  .Select(int.Parse)
                  .ToArray();
Console.Write("Задайте коэффициент масштабирования k = ");
int k = int.Parse(Console.ReadLine());
Console.WriteLine("Координаты, увеличенные на " + k);
for(int i = 0; i<str.Length; i=i+2)
{
    Console.Write($"({str[i]*k},{str[i+1]*k}) ");
}
