// 42. Определить, сколько чисел больше 0 введено с клавиатуры.
Console.WriteLine("Введите числа через пробел");
string[] str = Console.ReadLine().Split(' ');
int count = 0;
for(int i = 0; i<str.Length; i++)
{
    int num = int.Parse(str[i]);
    if(num > 0) count++;
}
if(count == 0) Console.WriteLine("Нет чисел больше 0");
else Console.WriteLine("Количество чисел больше 0 = " + count);
