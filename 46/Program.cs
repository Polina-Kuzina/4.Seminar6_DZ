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






//Console.Write("Задайте коэффициент масштабирования k = ");
//int k = int.Parse(Console.ReadLine());
//Console.WriteLine("Исходные координаты:");
//string text = "(1,2) (2,6) (3,9) (3,8)"
    //  .Replace("(","")
     // .Replace(")","")
    //  ;
//Console.WriteLine(text);
//var data = text.Split(" ")
      //  .Select(item => item.Split(','))
     //  .ToArray();
//Console.WriteLine("Координаты, увеличенные на " + k);
//for(int i = 0; i<data.Length; i++)
//{
  //  int x = int.Parse(data[i]);
   // x = x * k;
  //  for(int j = 0; j<data[i].Length; j++)
   // {
     //   int y = int.Parse(data[i][j]);
      //  y = y * k;
      //  Console.Write($"({x},{y}) ");
   // }
    // Console.Write(" ");
//}
// string[] str = Console.ReadLine().Split(' ');
