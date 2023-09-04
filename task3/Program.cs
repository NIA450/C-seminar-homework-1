// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int numberA = 3;
int numberB = 5;
int numberC = 8;
int max = numberC;
if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;
Console.WriteLine(max);
