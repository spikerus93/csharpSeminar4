// Напишите программу, которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadInt()
{
    Console.WriteLine("Введите Любое Число: ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Pro(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }
    return result;
}

int number = ReadInt();
int Pro1 = Pro(number);
Console.WriteLine($"Произведение чисел от 1 до {number} равно {Pro1}");