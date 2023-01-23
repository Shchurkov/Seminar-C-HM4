// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum (int A)
{
int sum = 0;
int res = 0;
while (A != 0)
{
    res = A %10;
    sum = sum + res;
    A = A / 10;
}
return sum;
}

Console.WriteLine( "Введите число  ");
int A = Convert.ToInt32(Console. ReadLine());
Console.WriteLine($"Cумма цифр в числе {A} равняется {Sum(A)}");
