


// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.Write("Введите трехзначное число: ");

int InNum = Convert.ToInt32(Console.ReadLine());

int OutNum = InNum % 10;

if (InNum >99 && InNum <1000){
    Console.Write($"Поледняя цифра числа {InNum} это {OutNum}");
}
else {
    Console.Write("Введенное число не трехзначное");
}

