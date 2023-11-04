//Внутри класса Answer напишите метод ShowCube, 
//который принимает на вход число (N) и выводит таблицу кубов
//чисел от 1 до N (включительно) каждое  на новой строке.

// Console.Write("N = ");
// int N = Convert.ToInt32(Console.ReadLine());
// for(int start = 1; start <= N; start++ )
// { 
//   Console.WriteLine($"{Math.Pow(start, 3 )}");
// }





//Внутри класса Answer напишите метод  DistanceBetweenPoints, 
//который принимает на вход координаты двух точек pointA и pointB 
// в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.

// using System.Globalization;

// int[] pointA;
//  int[] pointB;
// Console.Write(" Введите число x1:  ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write(" Введите число y1:  ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.Write(" Введите число z1:  ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.Write(" Введите число x1:  ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write(" Введите число y1 :  ");
// int y2 = Convert.ToInt32(Console.ReadLine());
      
// Console.Write(" Введите число z1 :  ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt((Math.Pow(x1 - x2, 2)) + (Math.Pow(y1 - y2, 2)) + (Math.Pow(z2 - z1, 2)));

// Console.WriteLine($"d = {Math.Round(d , 2)}");



// Внутри класса Answer напишите метод DistanceBetweenPoints, 
// который принимает на вход координаты двух точек pointA и
//  pointB в виде массива целых чисел, 
//  и возвращает расстояние между ними в 3D пространстве.

//  A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите значение координаты x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение координаты y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение координаты z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение координаты x1: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение координаты y1: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение ккоординаты z1: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 -y2, 2) + Math.Pow(z1 - z2, 2));
// Console.WriteLine($" d = {Math.Round(d , 2)}");



// Внутри класса Answer напишите метод ShowCube, 
// который принимает на вход число (N) и выводит таблицу кубов чисел 
// от 1 до N (включительно) каждое на новой строке.
// N = 3 
// 1
// 8
// 27

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for ( int firstNumber = 1; firstNumber <= N; firstNumber++ )
// {
//     Console.Write($"{Math.Pow(firstNumber, 3)} \t");
// }


// /Внутри класса Answer напишите метод IsPalindrome, 
// который принимает на вход пятизначное число number и проверяет,
//  является ли оно палиндромом.
//  Метод должен проверить является ли число пятизначным, 
// в противном случае - вывести Число не пятизначное и False в следующей строке.
//  Для остальных чисел вернуть True или False.
// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное


// Console.Write(" Введите пятичзначное число: ");
// int number;
// string stringNumber = Console.ReadLine();
// bool siNumber = int.TryParse(stringNumber, out number );
// if (siNumber)
// {
//      if(number < 10000 || number > 99999)
//     {  
//     Console.WriteLine(" Число не пятизначное ");
//     }
// else if (stringNumber[0] == stringNumber[4] && stringNumber[1] == stringNumber[3])     
//     {
//     Console.WriteLine($" {stringNumber} => True");
//     }
//     else
//     {
//     Console.WriteLine($" {stringNumber} => False");
//     }
//     }
// else 
// {
//     Console.WriteLine(" Число содержит символы!");
// }

















