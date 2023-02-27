/*
Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

using System;
using static System.Console;

Clear();
Write("Enter a number: ");
int number = int.Parse(ReadLine());
int end = 1;

WriteLine(PrintNaturNums(number, end));

string PrintNaturNums(int intNum, int intEnd)
{
    if (intEnd == intNum) return intNum.ToString();

    string result = PrintNaturNums(intNum, intEnd + 1) + ' ' + intEnd.ToString();
    return (result);
}