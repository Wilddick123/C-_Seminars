Console.Write("Введите номер дня недели: ");
int inNumberWeek = Convert.ToInt32(Console.ReadLine());


switch (inNumberWeek)
{
    case 1:
        Console.Write($"{inNumberWeek} -> Понедельник");
        break;

    case 2:
        Console.Write($"{inNumberWeek} -> Вторник");
        break;
    
    case 3:
        Console.Write($"{inNumberWeek} -> Среда");
        break;

    case 4:
        Console.Write($"{inNumberWeek} -> Четверг");
        break;

    case 5:
        Console.Write($"{inNumberWeek} -> Пятница");
        break;

    case 6:
        Console.Write($"{inNumberWeek} -> Суббота");
        break;

    case 7:
        Console.Write($"{inNumberWeek} -> Воскресенье");
        break;

    default:
        Console.Write($"Такого дня недели не существует");
        break;
}
