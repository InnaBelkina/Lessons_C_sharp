// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно 7 и 23 одновремненно

int number = new Random().Next(0, 1000);
System.Console.WriteLine($"Рандомное число равно {number}");

if (number % 7 == 0 && number % 23 == 0) System.Console.WriteLine($"{number} -> да");
else System.Console.WriteLine($"{number} -> нет");