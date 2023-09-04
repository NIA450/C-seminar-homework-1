// напишите программу: деление одного числа на другое

// double numberA = 12; можно писать целые числа
// double numberB = 5;
// Console.WriteLine(numberA / numberB);

// напишите программу, которая генерирует 2 случайных числа и выдает их сумму

 int numberA = new Random().Next(1,10); //это генератор чисел
 Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
