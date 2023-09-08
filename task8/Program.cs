// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

// Console.Write("Введите цифру, обозначающую день недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());

// void CheckingTheDayOfTheWeek (int dayNumber) {
//   if (dayNumber == 6 || dayNumber == 7) {
//   Console.WriteLine("это выходной");
//   }
//   else if (dayNumber < 1 || dayNumber > 7) {
//     Console.WriteLine("такого дня нет");
//   }
//   else Console.WriteLine("это не выходной день");
// }

// CheckingTheDayOfTheWeek(dayNumber);

// Идеальное решение от GB:
int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}
bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("это не день недели!");
    return false;
}
int weekday = Prompt("Введите день недели");
if (ValidateWeekday(weekday))
{
    if (IsWeekend(weekday))
    {
        Console.WriteLine("Наконец-то выходной!");
    }
    else
    {
        Console.WriteLine("Придется поработать!");
    }
}
