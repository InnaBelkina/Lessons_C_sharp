// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N,большее чем M: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных чисел от M до N = {sum(M, N)}");

int sum(int start, int end)
{
    // Console.Write($"{start} ");
    if (start > end) return 0;
    return start + sum(start + 1, end);
}