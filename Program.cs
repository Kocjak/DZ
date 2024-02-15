using System;

/*Задача 1: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в 
промежутке от M до N. Использовать рекурсию, не использовать циклы.*/

Console.Write("Введите начало отрезка (целое число): ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец отрезка (целое число): ");
int N = Convert.ToInt32(Console.ReadLine());
    void ShowNaturalNumbers(int M, int N)
    {
        if (M==N)
        {
            Console.Write(M);
            return;
        }
        else if (M>N)
            {
                Console.Write(N+" ");
                ShowNaturalNumbers(M, N+1);
            }
        else
            {   Console.Write(M+" ");
                ShowNaturalNumbers(M+1, N);
            }

    }

ShowNaturalNumbers(M,N);