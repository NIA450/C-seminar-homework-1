// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// Console.Write("Введите число: ");
// int anyNumber = Convert.ToInt32(Console.ReadLine());
// string anyNumberText = Convert.ToString(anyNumber);
// if (anyNumberText.Length > 2){
//   Console.WriteLine("третья цифра -> " + anyNumberText[2]);
// }
// else {
//   Console.WriteLine("-> третьей цифры нет");
// }

// Идеальное решение от GB:

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int GetThirdRank(int number)
{
    while (number >999)
    {
        number /= 10;
    }
    return number & 10;
}
bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("третьей цифры нет");
        return false;
    }
    return true;
}
int number = Prompt("Введите число >");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}

