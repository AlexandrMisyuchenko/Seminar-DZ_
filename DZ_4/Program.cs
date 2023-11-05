// Задача 25: Напишите цикл, который принимает на
// вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//  Вариант №1
// Console.Write("Введите число А: ");
// int numberA = Convert.ToInt32(Console.ReadLine()); 

// Console.Write("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine($"{numberA}, {numberB} => {Math.Pow(numberA, numberB )}");


//  Вариант №2
// Console.Write("Введите число А: ");
// int numberA = Convert.ToInt32(Console.ReadLine()); 

// Console.Write("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine()); 
// Console.Write($" Число {numberA} в степение {numberB} => {GetBegree(numberA, numberB)}");
// int GetBegree (int number, int Begree) // Get - получить, Begree - степень
// {
//     int sumBegree = 1;
//     for (int i = 0; i < Begree; i++ )
//     {
//         sumBegree *= number;
//     }
//     return sumBegree;
// }


// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12