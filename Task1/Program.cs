//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int Degree (int A, int B)
{
int degree = 0;
int A2 = A;
while (B > 1)
{
    B = B - 1;
    A = A * A2;
    degree = A;
}
return degree;
}
Console.WriteLine( "Введите число А ");
int A = Convert.ToInt32(Console. ReadLine());
Console.WriteLine( "Введите число B ");
int B = Convert.ToInt32(Console. ReadLine());
Console.WriteLine($"{A} в степени {B} равняется {Degree (A, B)}");