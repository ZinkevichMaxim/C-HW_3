﻿// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите целое число");
int nomber = int.Parse(Console.ReadLine());
int count = 1;

while (count <= nomber)
{
    int cubnomber = count * count * count;
    Console.Write(cubnomber + " / ");
    count = count + 1;
}





