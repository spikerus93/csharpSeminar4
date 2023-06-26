// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> нет


int[] GetRandomArray()
{
    int[] array = new int[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] =  Random.Shared.Next(-9, 10);
    }
    return array;
}

int[] array = GetRandomArray();
Console.WriteLine("Введите Число:  ");
int numberFind = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (numberFind == array[i])
    {
        count++;
    }
    
}
if (count == 1)
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }
int[] myArray = GetRandomArray();
Console.WriteLine($"[{string.Join(" ,", myArray)}]");