// int i = 0;
// while (i<10)
// {
//   i+=2;
// Console.Write(i+" ");
// }


Console.Write("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine("Квадрат от числа " + number + " = " + result);


// Напишите программу, которая будет 
// выдавать название дня недели,
// по заданному номеру.
// 3 => Среда
// 5 => Пятница

// Console.WriteLine("Введит число, дня недели: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if ( number == 1)
// {
//   Console.WriteLine("Понедельнтк");
// }
// else if (number == 2)
// {
//   Console.WriteLine("Вторник");
// }
// else if (number == 3)
// {
//   Console.WriteLine("Среда");
// }
// else if (number == 4)
// {
//   Console.WriteLine("Четверг");
// }
// else 
// {
//   Console.WriteLine(" Нет такого дня недели");
// }



// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа, от -N до N;
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4;

// Console.WriteLine("Введите число (N): ");
// int N  = Convert.ToInt32(Console.ReadLine());
// if (N < 0)
// {
//   N = N * (-1);
//   Console.WriteLine("Вы ввели число с отр. значением и я умножил его на -1 ");
// }
// int minusN = N *(-1);
// while  (minusN <= N)
// {

//   Console.Write(minusN + " ");
//    minusN +=1;// или minusN +=1;
// }



// задача #2 

// int a = -9;
// int b = -10;
// if (a > b)
// {
//   Console.WriteLine("max " + "= " + a);
// }
// else
// {
//   Console.WriteLine("max " + "= " + b);
// }

// Напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.

// int a = 881;
// int b = 24;
// int c = 80;

// int max = a;
// if ( max < b)
// {
//  max = b;
// }

// if ( max < c) 
// {
//     max = c;
// }
// Console.WriteLine(max);

// Напишите метод CheckIfEven, который на вход принимает число number и выводит, 
// является ли число чётным (делится ли оно на два без остатка).

// int number = 3;

// if ((number % 2) == 0)
// {
//     Console.WriteLine($"Число, {number }, четное ");
// }
// else
// {
//     Console.WriteLine($"Число, {number }, нечетное ");
// }



// Внутри класса Answer напишите метод PrintEvenNumbers, 
//которая на вход принимает число (number), 
//а на выходе выводит все чётные числа от 1 до number (включительно), разделеные знаком табуляции.
 
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
//  // берем 2 а не 1 так как четные начинаются с цифры 2;
// //  for (int count = 2;  count < number; count=+2  )
// int count = 2;
// while (count <= number)
// { 
//     Console.Write(count + " " );
//     count+=2;
// }
