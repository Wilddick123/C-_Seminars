// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.Write("Введите число: ");
int inNumber = Convert.ToInt32(Console.ReadLine());
int sqNumber = inNumber * inNumber;
Console.Write($"Квадрат числа {inNumber} = {sqNumber}");
 //Console.WriteLine(sqNumber);