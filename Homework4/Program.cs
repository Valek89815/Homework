﻿//Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2,4
//8 -> 2, 4, 6, 8

int n = Convert.ToInt32(Console.ReadLine());
int currentN= 1;

while(currentN <= n)
{
    if (currentN %2 == 0)
    {
        Console.WriteLine(currentN);
    }
    currentN ++;
}