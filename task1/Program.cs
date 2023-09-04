// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//  какое число большее, а какое меньшее.

var n1 = Decimal.Parse(Console.ReadLine());
var n2 = Decimal.Parse(Console.ReadLine());
if (n1 > n2)
Console.WriteLine(n1);
else
Console.WriteLine(n2);
