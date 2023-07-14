// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число А");
// int A = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число B");
// int B = Convert.ToInt32(Console.ReadLine());

// int GetDegree()
// {
//     int i, result = 1;
//     for (i=1; i<=B; i++)
//     {
//         result = result*A;
//     }
//     return result;
// }

// Console.WriteLine(GetDegree());


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumNum()
// {
//     int i, sum = 0, num = 0;
//     for (i=0; number > 0; i++)
//     {
//         num = number%10;
//         sum = sum + num;
//         number = number/10;
//     }
//     return sum;
// }

// Console.WriteLine(SumNum());



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int []array = new int [8];
// int i;

// void Array()
// {
//     for(i = 0; i < array.Length; i ++)
//     {
//         array[i] = new Random().Next();
//         Console.Write(array[i]+" "); 
//     }
// }

// Array();

// int []array = new int [8];
// int i;

// void Array()
// {
//     for(i = 0; i < array.Length; i ++)
//     {
//         Console.WriteLine("Введите число");
//         array[i] = Convert.ToInt32(Console.ReadLine()); 
//     }
//     for(i = 0; i < array.Length; i ++)
//     {
//         Console.Write(array[i]+" ");
//     }
// }

// Array();
