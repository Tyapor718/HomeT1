// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;
int A = 2;
while (count < N/2)
{
    if (A%2 == 0)
    {
        Console.Write (A + " ");
        A = A + 2;
    }
    else 
    {
        A = A + 1;
    }
count ++;
}
