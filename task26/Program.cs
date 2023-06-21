// Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt()
{
    Console.WriteLine("Введите Любое Число: ");
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int func(int number)
{
    int col = 0;
    while(number > 0)
    {
        number = number / 10;
        col++;
    }
    return col;
}

int number = ReadInt();
int col = func(number);
Console.WriteLine($"Количество цифр в Вашем числе: {col} ");


