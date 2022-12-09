int N;

Console.Write($"Введите число ");

int.TryParse(Console.ReadLine()!, out N);

Console.Write($"Число = {N / 10 % 10}");