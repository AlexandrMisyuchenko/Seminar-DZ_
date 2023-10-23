// // Напишите программу, которая выводит 
// // случайное число из отрезка [10, 99] и 
// // показывает наибольшую цифру числа.

// // Например:
// // 78 -> 8
// // 12-> 2
// // 85 -> 8
// // Next(min, max + 1)=> Next (10, 99 + 1)
// int number = new Random().Next(10, 100);
// // Интерполяция - удлбно, молодёжно, стильно
// // $ "Текст {переменная}текст"
// Console.WriteLine($"Рандомное число: {number}");

// int firstDigit =  number / 10;  // 78 /10 = 7 челых, остаток отбросили
// int secondDigit = number % 10;  // 78 % 10 = 8 в остатке
// int max = firstDigit; // Пусть максимальная цифра в числе 78
// if ( secondDigit > max) // 8(secondDigit) > 7(max), max =8(secondDigit)
// {
//     max = secondDigit;
// }
//     Console.WriteLine($"Максимальная цифра в числе {number} -> {max}");


// Напишите программу,
// которая выводит случайное
// трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98


// int number = new Random().Next(100, 1000); // 100 это начало трёхзначных чисел, а 1000 конец.
// int firstDigit =  number / 100; // 456 / 100 = 4
// int thirdDigit = number % 10; // 456 % 100 = 6
// // firstDigit  - кщличество десятков (4 десятка 4 *10 =40)
// // thirdDigit - количество едениц (6 едениц 6*1 =6)
// int result = firstDigit * 10 + thirdDigit;
// Console.WriteLine($"{number} -> {result}");

// Console.WriteLine("Введите число");
// string stringNumber = Console.ReadLine();
// // Строчка - массив символ
// int number; //Ничего не клал в неё
// // TryParse (строчка, out переменная для результата)
// bool isNumber = int.TryParse(stringNumber, out number);
// //Если isNumber == true, значит строчка isNumber
// // состоит ТОЛЬКО из цифр; False - в строке есть буквы.
// // если stringNumber только цифры в переменную number попадет само число; иначе - 0
// Console.WriteLine($"Длина строки(коичество символов): {stringNumber.Length }");
// if (isNumber && stringNumber.Length > 4 )
// {
//     Console.WriteLine("Ваша строчка состоит только из цифр");
//     Console.WriteLine($"{stringNumber} =>{stringNumber[0]}{stringNumber[2]}");
// }
// else
// {
//     Console.WriteLine("В строчке присутствуют буквы или длина строки < 3 символов ");
// }


// Напишите программу, которая
// принимает на вход числои
// и проверяет, кратно ли оно одновременно
// 7 и 23.

// 14 -> Нет
// 46 -> Нет
// 161 -> Да (7 * 23 = = 161, НОД наименьшее общее кртное)

// Console.WriteLine("Введите число:  ");
// int number = Convert.ToInt32(Console.ReadLine());
// //Convert.ToInt32 - конвертируем строку в число

//  if ((number % 7 == 0) && (number % 7 == 0))
//  {
//     Console.WriteLine("Число делится и на 7, и на 23 одновременно");
// } 
// else
// {
//     Console.WriteLine("Не делится на 7 или на 23: ");
    
// }


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine(" Введиье трехзначное число ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number > 999 || number < 100 )
// {
//   Console.WriteLine(" Не трехзначное число !!! ");
//   return;
// }
// else
// {
//     int remains = number % 100; // остаток 56
//     int secondDigit = remains / 10; //второеичисло от number =5
//     Console.WriteLine (secondDigit);
// // }


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine(" Введите число ");
// string stringNumber = Console.ReadLine();

// int number;
// bool isNumber = int.TryParse (stringNumber, out number);

// if (isNumber)
// {
//     if ( number < 100 )
//     {
//         Console.WriteLine(" Третьей цифры нет !!! ");
//         return;
//     }
//     else 
//     {
//        int thirDigit = int.Parse(Convert.ToString(number)[2].ToString());
//         Console.WriteLine(thirDigit);
//     }
// }
// else
// {
//     Console.WriteLine(" В строчке присутствуют буквы !! ");
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write(" Введите номер дня недели:  ");

// int numberOfDay;
// string stringDay = Console.ReadLine();
// bool siDay = int.TryParse(stringDay, out numberOfDay);
// if (siDay)
// {
    
//     if (numberOfDay == 1)
//     {
//         Console.WriteLine($"{numberOfDay} -> Нет ");
//     }
//     else if (numberOfDay == 2)
//     {
//         Console.WriteLine($"{numberOfDay} -> Нет ");
//     }
//     else if (numberOfDay == 3)  
//     {
//         Console.WriteLine($"{numberOfDay} -> Нет ");
//     }      
//     else if (numberOfDay == 4)
//     {   
//         Console.WriteLine($"{numberOfDay} -> Нет ");
//     }
//     else if (numberOfDay == 5)
//     {
//         Console.WriteLine($"{numberOfDay} -> Нет ");
//     }   
//     else if (numberOfDay == 6)
//     {
//         Console.WriteLine($"{numberOfDay} -> Да ");
//     }
//     else if (numberOfDay == 7)
//     {
//         Console.WriteLine($"{numberOfDay} -> Да ");
//     }
//     else
//     {
//         Console.WriteLine("Нет такого дня недели");
//     }
// }
// else
// {
//     Console.WriteLine(" Нет такого дня недели ");
// }

