﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int i = 1;

Console.WriteLine("Четные числа от 1 до " +a + ":");

while(i<=a)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i++;
}