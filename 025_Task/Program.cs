/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

*/

double numberPow(double a, int b)
{
    double res = 1;
        for (int i = 1; i <= b; i++)
    {
        res *= a;
    }
    return res;
}

Console.Write("Введите число А -> ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число B -> ");
int B = Convert.ToInt32(Console.ReadLine());
if (B < 1)
{
    Console.Write("Число B должно быть натуральным!");
    return;
}
Console.WriteLine($"Число {A} в степени {B} равно {numberPow(A, B)}");