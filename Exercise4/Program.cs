﻿Console.WriteLine("Введите число.");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= N)
{
    if (i % 2 ==0)
    {
        Console.WriteLine("Четное число от 1 до " + N + ": " + i + ".");
    }
    i++;
}