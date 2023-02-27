/*
Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;
using static System.Console;

Clear();
Write("Enter M: ");
int startNum = int.Parse(ReadLine());
Write("Enter N: ");
int endNum = int.Parse(ReadLine());

WriteLine($"Sum of natural elements between M and N is {SumNaturNums(startNum, endNum)}");

int SumNaturNums(int localStartNum, int localEndNum)
{
    int intSum;
    if (localEndNum == localStartNum) return localEndNum;
    else intSum = localEndNum + SumNaturNums(localStartNum, localEndNum - 1);
    return intSum;
}

