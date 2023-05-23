// ﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// // 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

// int Degree(int a, int b)
// {
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//         result *= a;
//     return result;
// }

// System.Console.WriteLine("Ввведите натуральное число A:");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Ввведите натуральное число B:");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Число {a} в степени {b} равно: {Degree(a, b)}");






// ﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// int Summ(int num)
// {
//     int result = 0;
//     while (num > 0)
//     {
//         result += num % 10;
//         num = num / 10;
//     }
//     return result;
// }


// System.Console.WriteLine("Введите любое число:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма цифр в числе {num}, составляет: {Summ(num)}");






// ﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

// int [] CreateArray()
// {
//     Random random = new Random();
//     int[] numbers = new int[8];
//     System.Console.Write("Массив:");
//     for (int x = 0; x < numbers.Length; x++)
//         numbers[x] = random.Next(1, 100);
//     return numbers;
// }

// void PrintArray(int [] numbers)
// {
//     for (int x = 0; x < numbers.Length; x++)
//     System.Console.Write($" {numbers[x]}");
//     Console.WriteLine();
// }
 

// int [] numbers = CreateArray();
// PrintArray(numbers);





// ﻿// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число 
// // и выдаёт количество цифр в числе.
// // 456 -> 3
// // 0 -> 1
// // 89,126 -> 5
// // 0,001->4


// int CountDig(double num)
// {
//      int count = 0;
//      string number = num.ToString();
//      for (int i = 0; i < number.Length; i++)
//      {
//         if (char.IsDigit(number[i]))
//         {
//             count++;
//         }
//      }
//      return count;
// }


// System.Console.WriteLine("Введите целое или дробное число:");
// double num = double.Parse(Console.ReadLine());
// System.Console.WriteLine($"Количество цифр в цисле {num}: {CountDig(num)}");