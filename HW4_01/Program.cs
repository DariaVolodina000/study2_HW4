// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// / Не использовать Math.Pow

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int IntPutInt(string messege)
{
    Console.WriteLine(messege);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int a = IntPutInt("Введите число A > ");
int b = IntPutInt("Введите число B > ");
int result = 1;
for (int i = 0; i < b; i++)
{
    result = result *a;
}
Console.Write($"Число A в натуральной степени B равна {result}");



