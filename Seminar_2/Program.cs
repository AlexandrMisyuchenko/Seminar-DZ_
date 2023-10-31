// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 99);
int firstNumber = number / 10;
int secondNumber = number % 10;
if (firstNumber > secondNumber)
{
    int max = firstNumber;
    Console.WriteLine($" Рандомное число: {number } => { max}");
}
else
{
    int max = secondNumber;
    Console.WriteLine($" Рандомное число: {number } => { max}");
}

закончил в 1:07:00
