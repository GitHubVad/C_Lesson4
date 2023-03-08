// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число которое нужно возвести в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число в степень которого нужно возвести число а: ");
int b = Convert.ToInt32(Console.ReadLine());

Stepen(a,b);

void Stepen(int a, int b)
{
    int step = Convert.ToInt32(Math.Pow(a,b));
    Console.Write($"{a},{b} -> {step}");
}

