

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
// }


// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 456

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.Write($"Количечтво цифр в числе {number} => {GetCountNumber(number)}");
// int GetCountNumber (int num)
// {
//     if (num == 0)
//   {
//     return  1;
//   }
//   else
//    {
//         int count = 0;
//         while( num > 0)
//         {
//             count++;
//             num /= 10;
//         }
//         return count;
//     }
// }

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
int[] result = GetBinaryArray (8);// Получили массив на 8 элементов
Console.WriteLine($"[{String.Join("; ", result)}]");
int[] GetBinaryArray (int size)
{
    // тип данных [] имя_масива  = new int[размер]
    int[] array = new int [size];
    // Изначально массив заполнен НУЛЯМИ
    for ( int i = 0; i < array.Length; i++)
    // array.Length = size
    {
        array[i] = new Random().Next(0, 2);
        // кладём в каждую переменную [i] рандомное число
        // Next(2) => Next(0, 2)
    }
    return array;
}


