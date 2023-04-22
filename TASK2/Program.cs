
// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

Console.Write("Введите номер дня недели: ");
int inNumberWeek = Convert.ToInt32(Console.ReadLine());



if(1 == inNumberWeek){
    Console.Write($"{inNumberWeek} -> Понедельник");
}
else if(2 == inNumberWeek) {
    Console.Write($"{inNumberWeek} -> Вторник");

}
else if(3 == inNumberWeek) {
    Console.Write($"{inNumberWeek} -> Среда");

}
else if(4 == inNumberWeek) {
    Console.Write($"{inNumberWeek} -> Четверг");

}
else if(5 == inNumberWeek) {
    Console.Write($"{inNumberWeek} -> Пятница");

}
else if(6 == inNumberWeek) {
    Console.Write($"{inNumberWeek} -> Суббота");

}
else if(7 == inNumberWeek) {
    Console.Write($"{inNumberWeek} -> Воскресенье");

}
else{
    Console.Write($"Такого дня недели не существует");
}