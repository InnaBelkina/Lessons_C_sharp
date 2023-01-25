// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
else if (k1 == k2) Console.WriteLine("Прямые параллельны");
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"({(string.Join(";", x, y))})");
}



// Console.Clear();
// Console.Write("Введите через пробел b1, k1, b2 , k2: ");
// string[] f = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
// double b1 = double.Parse(f[0]);
// double k1 = double.Parse(f[1]);
// double b2 = double.Parse(f[2]);
// double k2 = double.Parse(f[3]);

// Console.WriteLine(String.Join(" ", GetPoint(b1, k1, b2, k2)));

// double[] GetPoint(double inB1, double inK1, double inB2, double inK2)
// {
//     double[] result = new double[2];
//     result[0] = (inB2 - inB1) / (inK1 - inK2);
//     result[1] = inK1 * result[0] + inB1;
//     return result;
// }


