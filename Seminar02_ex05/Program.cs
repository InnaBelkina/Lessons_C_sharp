﻿// напишите программу, которая принимает на вход 2 числа, и проверяет является ли одно число квадратом другого
 

 Console.WriteLine("Введите первое число ");
 int number1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число ");
 int number2 = Convert.ToInt32(Console.ReadLine());

 if(number1 == number2*number2 || number1*number1 == number2) Console.WriteLine("да");
 else Console.WriteLine("нет");