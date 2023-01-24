//  Принимаем трехзначное число и убираем из него вторую цифру
//  456 -> 46

// Console.Write("Введите трехзначное число: ");
// string stringNumber = Console.ReadLine().Trim(); // trim убирает пробел с начала строки и с конца строки
// System.Console.WriteLine($"{stringNumber} -> {stringNumber[0]}{stringNumber[2]}");

int number = new Random().Next(10,1000);
Console.WriteLine ($"Рандомное число: {number}");
Console.WriteLine ($"Ответ {number / 100 * 10 + number % 10}");