// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 8 && num > 0)
    if (num < 6)
        Console.WriteLine("Нет");
    else
        Console.WriteLine("Да");
else
    Console.WriteLine("ОТ ОДНОГО ДО СЕМИ!!! НЕ МЕНЬШЕ ОДНОГО И НЕ БОЛЬШЕ СЕМИ!");