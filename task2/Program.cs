// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N

Console.Write("Введите положительное число: ");
int num = int.Parse(Console.ReadLine());
int i = 2;
if (i > num) Console.WriteLine("Четных чисел от 1 до введеного числа нет");
while (i <= num)
{
    if ((i % 2 == 0 && i == num) || (i % 2 == 0 && i + 1 == num))
    {
        Console.Write(i);
    }
    else if (i % 2 == 0) 
    {
        Console.Write(i + ",");
    }
    i++;
}
