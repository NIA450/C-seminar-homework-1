﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.


// Console.Write("Введите трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("вторая цифра числа -> "+stringNumber[1]);

// Идеальное решение от GB:
int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number = Prompt("Введите трехзначное число > ");
if (number <100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожалуйста, повторите");
    return;
}
Console.WriteLine($"Введеное число `{number}`");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра `{secondRank}`");