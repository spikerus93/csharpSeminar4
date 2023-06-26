﻿// Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetRandomArray()
{
    int[] array = new int[4];
    for(int i =0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9, 10);
    }
    return array;
}

int[] array = GetRandomArray();
Console.Write("Это Начальный Массив - ");
Console.WriteLine(string.Join(", " , array));
for(int i =0; i < array.Length; i++)
{
    array[i]=-array[i];
}
Console.Write("Это Измененный Массив - ");
Console.WriteLine(string.Join(", " , array));