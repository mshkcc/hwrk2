int day;

Console.Write($"Введите день ");

int.TryParse(Console.ReadLine()!, out day);

if (day == 6 || day == 7)
    Console.Write($"Этот день выходной!");
else if (day > 0 && day < 6)
    Console.Write($"Это будний день");
else
    Console.Write($"Не день недели");