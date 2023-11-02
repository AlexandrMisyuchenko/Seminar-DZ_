// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int number = new Random().Next(10, 99);
// int firstNumber = number / 10;
// int secondNumber = number % 10;
// if (firstNumber > secondNumber)
// {
//     int max = firstNumber;
//     Console.WriteLine($" Рандомное число: {number } => { max}");
// }
// else
// {
//     int max = secondNumber;
//     Console.WriteLine($" Рандомное число: {number } => { max}");
// }


// Напишите программу,которая выводит
// случайное трехзначное число и удаляет
// вторую цифру этого чсла:
// 456 => 46
// Решение #1 (через числа, int)
// int number = new Random().Next(100,1000);
// int firstNumber = number / 100;
// int thréeNumber = number % 10;
// int result = firstNumber *10+ thréeNumber;
// Console.WriteLine($" {number} => {result}");

// Решение #2(через строку,string);

// Console.WriteLine("Введите трех значное число: ");
// string stringNumber = Console.ReadLine();
// int number;
// bool isNumber = int.TryParse(stringNumber, out number);
// Console.WriteLine($"Длина строчки(количество символов) {stringNumber.Length}");
// if (isNumber && stringNumber.Length < 4)
// {
//     Console.WriteLine("Ваше число, состоит ТОЛЬКО из цифр");
//     Console.WriteLine($"{stringNumber} => {stringNumber[0]}{stringNumber[2]}");
// }
// else 
// {
// Console.WriteLine($"Ваще число, состоит не только из цифр или длина строки < 3 символов");
// }


//  //Console.WriteLine($"isNumber => {isNumber}");
//  //Console.WriteLine($"stringNumber => {stringNumber}");
 
 
 
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23:
// 14 => нет
// 26 => нет
// 161 => да

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if ((number % 7 == 0) && (number % 23 == 0))
// {
//     Console.WriteLine($"Ваше число { number } кратно 7 и 23 одновремено");
// }
// else
// {
//     Console.WriteLine($" Ваше число { number } не кратно 7 и 23 одновоеменно");
// }



