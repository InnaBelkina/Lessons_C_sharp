// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n,большее чем M: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(fAkk(m, n));

int fAkk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return fAkk(m - 1, 1);
    else return fAkk(m - 1, fAkk(m, n - 1));
}