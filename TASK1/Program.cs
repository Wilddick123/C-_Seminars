
// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет
// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница


Console.Write("Введите первое число: ");
int inNumberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int inNumberTwo = Convert.ToInt32(Console.ReadLine());

int sqNumber = inNumberTwo * inNumberTwo;

if(inNumberOne == sqNumber){
    Console.Write($"Число {inNumberOne} является квадратом числа {inNumberTwo}");
}
else{
    Console.Write($"Число {inNumberOne} не является квадратом числа {inNumberTwo}");
}