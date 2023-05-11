// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру 
// этого числа.

// 456 -> 5
// 782 -> 8 
// 918 -> 1


// Console.WriteLine("Введите трёхзначное число");
// int number = Convert.ToInt32(Console.ReadLine());

// int lastDigit = number % 10;
// int firstDigit = number / 100;
// int res = firstDigit * 10 + lastDigit;

// Console.WriteLine(res);

// Console.WriteLine("Введите трехзначное число ");
// while(true)
//     {
//         string input = Console.ReadLine();
//         if(!input.Equals("exit"))
//             Console.WriteLine("{0}->{1}",input, input[1]);
//         else
//             break;
//     }

Console.Write("Введи трёхзначное число ");

int userNumber = Convert.ToInt32(Console.ReadLine());
string secondNumber = Convert.ToString(userNumber);
Console.WriteLine(secondNumber[1]);
