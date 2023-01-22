// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите число №1");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 == number_2)
{
    Console.WriteLine("Числа равны");
}
else
{

    if (number_1 > number_2)
    {
        Console.WriteLine("Число " + number_1 + " больше числа " + number_2);
    }
    else
    {
        Console.WriteLine("Число " + number_2 + " больше числа " + number_1);
    }
}

// Тут можно обойтись без вложенных блоков, если использовать конструкцию if – else if – else:

// if (num1 > num2)
// …
// else if (num1 < num2)
// …
// else
// ...