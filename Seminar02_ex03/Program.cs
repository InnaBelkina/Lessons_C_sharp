//  Напишите программу, которая будет принимать на вход да числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно 1, то программа выводит остаток от деления.

//  34, 5 -> не кратно, остаток 4
//  16, 4 -> кратно

internal class Program
{
private static void Main(string[] args)
{
int number1 = EnterNumber("Введите первое число");
int number2 = EnterNumber("Введите второе число");

if (number1 % number2 == 0) Console.WriteLine($"число 2 кратно 1");
else Console.WriteLine($"не крастно, остаток {number1%number2}");
}

static int EnterNumber(string str)
{
    System.Console.WriteLine(str);
    string stringNumber = Console.ReadLine()!.Trim();
    int number;
    while (!int.TryParse(stringNumber, out number))     // tryParse пытается преобразовать stringNumber в число
    // и вывести его в number. и возвращает true или false
    {
        Console.WriteLine("Ошибка! Введите одно целое число");      // эти 2 строчки если не получилось
        stringNumber = Console.ReadLine()!.Trim();                  // эти 2 строчки если не получилось
    }
    return number;
}
}