﻿// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N%2 == 0)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}