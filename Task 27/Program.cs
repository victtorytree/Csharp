﻿// выдаёт сумму цифр в числе
using System;
using static System.Console;

Clear();
Write("Введите число: ");
Write(SumOfFigures(int.Parse(ReadLine())));

int SumOfFigures(int SetN)
{
    int count=0;
    while (SetN>0)
    {
        count=count+SetN%10;
        SetN/=10;
    }
    return count;
}
