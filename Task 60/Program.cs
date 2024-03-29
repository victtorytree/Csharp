﻿// Формирует трехмерный массив, и выводит элементы построчно с указанием индекса

using System;

Console.Clear();

void GetArrayMyVariant (int par1, int par2, int par3)
{
    int[,,] array = new int[par1, par2, par3];
    for (int i = 0; i < par1; i++)
    {
        for (int j = 0; j < par2; j++)
        {
            for (int k = 0; k < par3; k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            continue;
        }
        Console.WriteLine();
    }
}

//не поняла вывод в условии задачи, т.к. в моем воображении трехмерный это кубик, и ПОСТРОЧНО я бы выводила по 4 элемента
// ниже в методе "подогнала" вывод под указанный в примере

void FillArray (int par1, int par2, int par3)
{
    int[,,] result = new int[par1, par2, par3];
    for (int k = 0; k < par3; k++)
    {
        for (int i = 0; i < par1; i++)
        {
            for (int j = 0; j < par2; j++)
            {
                result[i, j, k] = new Random().Next(10, 100);
                Console.Write($"{result[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        } 
    }
}
GetArrayMyVariant(2,2,2);
Console.WriteLine();
FillArray(2,2,2);
