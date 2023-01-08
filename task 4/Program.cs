﻿// Написать программу возведения числа А в целую степень B.
int PowNum(int A, int B)
{
    if (B == 0) return 1;
    else if (B == 1) return A;
    return A * PowNum(A, B - 1);
}
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите степень B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {A} возведенное в степень {B} равно {PowNum(A, B)}");

