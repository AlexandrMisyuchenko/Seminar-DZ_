// Напишите программу, которая подсчитывает количество четных элементов 
// в массиве целых положительных трехзначных чисел и выводит результат на экран.
// Программа должна иметь метод CountEvenElements, который принимает массив целых 
// положительных трехзначных чисел и возвращает количество четных элементов в массиве.

// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

// При выводе элементы массива должны быть разделены символом табуляции "\t".

// Если аргументы командной строки не переданы, программа использует массив по умолчанию, 
// который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}.

int[] res = GetArry(8, 100, 999);
Console.Write($"Массив искомый: [{String.Join(", ", res)}]");
int[] GetArry(int size, int min, int max)
{
    int [] arry = new int[size];// Изначально массив из нулей
    for(int i = 0; i< size; i++) // arry.Length
    {
        // min = -9, max = 9; max пишем как 9+1 либо цифрой 10ж
        arry[i] = new Random().Next(min, max +1);
    }
    return arry;
}
// bool ColSch (int[] array)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] %2 == 0)
//         {
//             count ++; 
//         }
//         }
//         else
//         {
//             Console.Write($"Количество чётных элементов: {count}");   
//         }
//     } 
// }
  









// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");
// PrintArray(numbers);
// int count = 0;

// for (int z = 0; z < numbers.Length; z++)
// if (numbers[z] % 2 == 0)
// count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100,1000);
//     }
// }
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }
