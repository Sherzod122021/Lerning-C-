﻿    // Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

    // 5 -> 2, 4
    // 8 -> 2, 4, 6, 8

    System.Console.WriteLine("Введите число ");

    int N = Convert.ToInt32(System.Console.ReadLine());
    int count = 2;

    while (count <= N )
       System.Console.WriteLine( count );
        count = count + 2 ;
        

