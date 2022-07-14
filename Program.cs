int number = new Random().Next(100,999);
Console.WriteLine($"Наше случайное число = {number}");
int numberB =number / 100;
int numberC =number / 10 % 10;
int numberD =number % 10;
int result = numberB / 10 + numberC;
Console.WriteLine($"{result}");