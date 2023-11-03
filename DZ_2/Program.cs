// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Введите трехзначное число");
// int number = Convert.ToInt32(Console.ReadLine());
// if ( number > 999 || number < 100 )
// {
//     Console.Write("Число не трёхзначное!!!");
// }
// else
// {
//     int rest = number % 100;
//     int premierNombre = rest / 10;
//     Console.WriteLine($"{number } => {premierNombre}");
// }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число: ");
// string stringNumber = Console.ReadLine();
// int number;
// bool isNumber = int.TryParse(stringNumber, out number);
// if (number <= 1000)
// {
//     Console.Write(" Число не содержит третьей цифры или в значении присутствуют буквы!!");
// }
// else 
// {
//      Console.WriteLine($"{stringNumber} => {stringNumber[2]}");
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
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

