/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int [] Input(int a)
{
    int [] array = new int [a];
    for (int i = 0; i < a; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива -> ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

Console.WriteLine("Получен массив: [" + String.Join(", ", Input(8)) + "]");