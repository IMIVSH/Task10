// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Введите ваше трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);
int count = number;
int lengthCounter = 0;

    while (count > 0)
{
    lengthCounter++;
    count = count/10;
}

if (lengthCounter != 3)
{
    Console.WriteLine("Вы ввели неверное число!");
}
else
{
    number = number / 10;
    number = number % 10;
    Console.WriteLine(number);
}