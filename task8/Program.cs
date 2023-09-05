// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("это выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("такого дня нет");
  }
  else Console.WriteLine("это не выходной день");
}

CheckingTheDayOfTheWeek(dayNumber);
