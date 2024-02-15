using System;
using System.IO.Compression;

/*Задача 1: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в 
промежутке от M до N. Использовать рекурсию, не использовать циклы.*/

/*Console.Write("Введите начало отрезка (целое число): ");
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

ShowNaturalNumbers(M,N); */

/*Задача 2: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.*/

/*Console.WriteLine("Функци Аккермана задается в виде Acr=(M, N)");
Console.WriteLine("Значения M и N не могут быть отрицательными");
Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

void CheckNumbers(int M, int N)
{}
int CalculateTheAckermanFunction(int M, int N)
    {   
        if (M<0 || N <0) throw new ArgumentOutOfRangeException();
        if (M==0) return N+1;
        if (N==0) return M+1;
        else return CalculateTheAckermanFunction(M-1, CalculateTheAckermanFunction(M,N-1));
    }

Console.WriteLine(CalculateTheAckermanFunction(M,N));*/


/*Задача 3: Задайте произвольный массив. 
Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.*/

int[] arr = {1,2,3,4,5};
int size=arr.Length-1;
ShowArray(arr, size);
static void ShowArray(int[] arr, int size)
{
    if (size==0)
    {
        Console.Write($"{arr[size]} ");
        return;
    }  
    else 
        {
        Console.Write($"{arr[size]} ");
        size--;
        }
    ShowArray(arr, size);
}
