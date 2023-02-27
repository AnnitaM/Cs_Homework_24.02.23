/*
Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
//                     m = 0 => n + 1;
// Ack(m, n)    m > 0, n = 0 => Ack(m - 1, 1);
//              m > 0, n > 0 => Ack(m - 1, Ack(m, n - 1));
/*
Ack(0, 0) = 0 + 1 = 1;
Ack(0, 1) = 1 + 1 = 2;
Ack(1, 0) = Ack(0, 1) = n + 1 = 2;
Ack(1, 1) = Ack(0, Ack(1, 0)) = Ack(0, 1) + 1 = 3;
Ack(1, 2) = Ack(0, Ack(1, 1)) = Ack(1, 1) + 1 = Ack(0, Ack(1, 0)) + 1 + 1 = 4;
Ack(2, 0) = Ack(1, 1) = Ack(0, Ack(1, 0)) = Ack(1, 0) + 1 = 3;
Ack(2, 1) = Ack(1, Ack(2, 0)) = Ack(2, 0) + 2 = 3 + 2 = 5;
Ack(2, 2) = Ack(1, Ack(2, 1)) = Ack(2, 1) + 2 = 5 + 2 = 7;
Ack(2, 3) = Ack(1, Ack(2, 2)) = Ack(2, 2) + 2 = 7 + 2 = 9;
Ack(2, 4) = Ack(1, Ack(2, 3)) = Ack(2, 3) + 2 = 9 + 2 = 11;
Ack(3, 0) = Ack(2, 1) = Ack(1, Ack(2, 0)) = Ack(2, 0) + 2 = 3 + 2 = 5;
Ack(3, 1) = Ack(2, Ack(3, 0)) = 2 * Ack(3, 0) + 3 = 2 * 5 + 3 = 13;
Ack(3, 2) = Ack(2, Ack(3, 1)) = 2 * Ack(3, 1) + 3 = 2 * 13 + 3 = 29;
Ack(3, 3) = Ack(2, Ack(3, 2)) = 2 * Ack(3, 2) + 3 = 2 * 29 + 3 = 61;
Ack(3, 4) = Ack(2, Ack(3, 3)) = 2 * Ack(3, 3) + 3 = 2 * 61 + 3 = 125;
*/

using System;
using static System.Console;

Clear();
Write("Enter M: ");
int argM = int.Parse(ReadLine());
Write("Enter N: ");
int argN = int.Parse(ReadLine());

Console.WriteLine(AckFunk(argM,argN));

int AckFunk(int localArgM, int localArgN)
{
    if (localArgM == 0) return localArgN + 1;
    else
    if (localArgM > 0 && localArgN == 0) return AckFunk(localArgM - 1, 1);
    else return AckFunk(localArgM - 1, AckFunk(localArgM, localArgN - 1));
}


