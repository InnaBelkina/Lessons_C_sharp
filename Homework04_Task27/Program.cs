// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
int Sum(int number)
{
    int result = 0;
    for (int i = number; i > 0; i = i / 10)
    {
        result = result + i % 10;
    }
    return result;
}

Console.WriteLine("Введите число a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {a} = {Sum(a)}");