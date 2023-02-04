//  Задача 2: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе. 
// Реализовать через функции.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите чило >");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int advance = 0;
while (num > 0)
{
    advance = num % 10;
    sum = sum + advance;
    num = num / 10;
}
Console.WriteLine($"Сумма чисел = {sum} ");
