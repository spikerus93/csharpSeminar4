// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[]numbers = {1,2,6,5,7,9};
int[]numbers2 = new int[(numbers.Length+1)/2];

for(int i=0; i < numbers2.Length;i++)
{
    numbers2[i] = numbers[i] * numbers[numbers.Length-1-i];
}

if(numbers.Length%2 !=0)
{
    numbers2[numbers2.Length -1] = numbers[numbers.Length/2];
}
Console.Write($"Пары:  ");
Console.WriteLine($"[ {String.Join(", ", numbers2)} ]");
