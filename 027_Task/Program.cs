/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int NumberSum(int a)
{
    a = Math.Abs(a);
    int sum = 0;
    while (a > 0)
    {
        int i = a % 10;
        a /= 10;
        sum += i;
    }
    return sum;
}

Console.Write("Введите число -> ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма цифр в числе {A} равно {NumberSum(A)}");