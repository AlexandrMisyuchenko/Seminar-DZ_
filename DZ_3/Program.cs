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


// // Внутри класса Answer напишите метод IsPalindrome, 
// который принимает на вход пятизначное число number и проверяет,
//  является ли оно палиндромом.
// // Метод должен проверить является ли число пятизначным, 
// в противном случае - вывести Число не пятизначное и False в следующей строке.
// // Для остальных чисел вернуть True или False.

Console.WriteLine("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number < 10000 || number > 99999)
{
    Console.WriteLine("Число не пятизначное ");
    Console.WriteLine("False");
}
else 
Console.WriteLine(number);



