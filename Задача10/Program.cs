// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру 
// этого числа.

// 456 -> 5
// 782 -> 8 
// 918 -> 1

Console.Write("Введи трёхзначное число ");

int userNumber = Convert.ToInt32(Console.ReadLine());
string secondNumber = Convert.ToString(userNumber);
Console.WriteLine(secondNumber[1]);
