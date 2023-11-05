

// !!!! Методы !!!!

// Методы можно повторно использрвать, просто поменяв данные;

// Метолы: которые возвращают значения и voitd
// тип_метоад ИмяМетода(параметр1, параметр2)
// Параметра: два числа и знак арифм. операции

// int Calculate(int first, int second, char sign)
// {
//     if (sign == '+') // '' - это только для char
//     {
//         return first + second;
//     }
//      else if (sign == '-') // '' - это только для char
//     {
//         return first - second;
//     }
//      else if (sign == '*') // '' - это только для char
//     {
//         return first * second;
//     }
//     else if (sign == '/') // '' - это только для char
//     {
//         return first / second;
//     }
//    else // Другие "знаки": все, кроме "+", "-", "*";
//    {
//     Console.WriteLine("Ошибка при вводе знака");
//     return 0;
//    }
// }
// //Calculate(int first, int second, char sign)
// // Используем метод - вызов
// Console.WriteLine(Calculate(100, 5, '+'));
// // first=2, second=5, char= +;
// Console.WriteLine(Calculate(100, 35, '-'));
// // first=2, second=5, char= +;
// Console.WriteLine(Calculate(100, 35, '*'  ));
// // first=2, second=5, char= +;
// Console.WriteLine(Calculate(2, 3, '/'));
// // first=2, second=5, char= +;


// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10 
// 8 -> 36

// Console.Write("Введите число А: ");
// int limit = Convert.ToInt32(Console.ReadLine());
// // limit  - до этого числа идём;
// Console.WriteLine($"Сумма чисел от 1 до {limit} = {GetSum(limit)}");
// int GetSum(int A) // Get-получить
// {
//     int sum =0; // переменная для хранения суммы
//     for (int i = 1; i <= A; i++)
//     {
//         sum += i;
//     }
//     return sum;
// 

// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5