// Напишите программу, которая выводит третью цифру слева заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 3267912 -> 6

Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int n = num;

while (n > 999)
{
    n = n / 10;
}

if (n < 99)

{
    Console.WriteLine("Третьей цифры нет");
}

else

{
    n = (n % 10);
    Console.WriteLine(n);
}
