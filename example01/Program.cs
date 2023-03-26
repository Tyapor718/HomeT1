//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int N2 = Convert.ToInt32(Console.ReadLine());
if (N1 >= N2)
{
    Console.WriteLine("Большее число " + N1);
}
else Console.WriteLine("Большее число " + N2);