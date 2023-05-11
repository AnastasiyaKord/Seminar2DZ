// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine ("Введите число, обозначающее день недели ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7)
 {
  Console.WriteLine("(Этот день недели является выходным) -> да");
 }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("Нет такого дня недели");
  }
  else Console.WriteLine("(Этот день недели является выходным) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber);

