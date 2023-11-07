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

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Сумма всех цифр в числе {number} => {SumNunber(number)}");
// int SumNunber ( int num)
// {
//   int sum = 0;
//   while( num > 0 )
//   {
//   sum = sum + num % 10;
//   num /= 10;
//   }
//   return sum;
// }


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] result = GetBinaryArray (8);// Получили массив на 8 элементов
// Console.WriteLine($"[{String.Join("; ", result)}]");
// int[] GetBinaryArray (int size)
// {
//     // тип данных [] имя_масива  = new int[размер]
//     int[] array = new int [size];
//     // Изначально массив заполнен НУЛЯМИ
//     for ( int i = 0; i < array.Length; i++)
//     // array.Length = size
//     {
//         array[i] = new Random().Next(7, 131);
//         // кладём в каждую переменную [i] рандомное число
//         // Next(2) => Next(0, 2)
//     }
//     return array;
// }
