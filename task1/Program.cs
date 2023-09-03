// Console.Write("Введите число a: ");
// int a = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число b: ");
// int b = int.Parse(Console.ReadLine()!);

// if (a == (b * b))
// {
//     Console.WriteLine("True");
// }
// else
// {
//     Console.WriteLine("False");
// }
// Console.WriteLine("Введите номер дня недели: ");
// string num = Console.ReadLine();
// switch (num)
// {
//     case "1":
//     Console.WriteLine("ПН: ");
//     break;
//     case "2":
//     Console.WriteLine("ВТ: ");
//     break;
//     case "3":
//     Console.WriteLine("СР: ");
//     break;
//     case "4":
//     Console.WriteLine("ЧТ: ");
//     break;
//     case "5":
//     Console.WriteLine("ПТ: ");
//     break;
//     case "6":
//     Console.WriteLine("СБ: ");
//     break;
//     case "7":
//     Console.WriteLine("ВС: ");
//     break;
//     default:
//     Console.WriteLine("нет такого: ");
//     break;
// }

var n1 = Decimal.Parse(Console.ReadLine());
var n2 = Decimal.Parse(Console.ReadLine());
if (n1 > n2)
Console.WriteLine(n1);
else
Console.WriteLine(n2);