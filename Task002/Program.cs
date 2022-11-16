// Напишите программу,
// 1. на вход принимает два числа 
// 2. выдаёт, какое число большее, а какое меньшее.

// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое чиcло : ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе чиcло : ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine("max = " + n1);
}
else
{
    Console.WriteLine("max = " + n2);
}