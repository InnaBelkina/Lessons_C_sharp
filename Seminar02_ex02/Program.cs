//  Принимаем трехзначное число и убираем из него вторую цифру
//  456 -> 46

// Console.Write("Введите трехзначное число: ");
// string stringNumber = Console.ReadLine().Trim(); // trim убирает пробел с начала строки и с конца строки
// System.Console.WriteLine($"{stringNumber} -> {stringNumber[0]}{stringNumber[2]}");


// int number = new Random().Next(10,1000);
// Console.WriteLine ($"Рандомное число: {number}");
// Console.WriteLine ($"Ответ {number / 100 * 10 + number % 10}");


// int number = new Random().Next(100,1000);
// Console.WriteLine(number);

string str = number.ToString();
int[] array = new int[str.Length];
for (int i = 0; i < str.Length; i++)
{
    array[i] = int.Parse(str[i].ToString());
}
Console.Write(array[0]);
Console.WriteLine(array[2]);