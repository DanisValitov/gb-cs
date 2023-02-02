// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.WriteLine("Enter a:");

// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter b:");

// int b = Convert.ToInt32(Console.ReadLine());

// int max = a > b ? a : b;

// String res = String.Format("a = {0} b = {1} -> max = {2}", a, b, max);

// Console.WriteLine(res);

//2 Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Console.WriteLine("Enter a:");

// int a = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter b:");

// int b = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter c:");

// int c = Convert.ToInt32(Console.ReadLine());

// int max = a;

// if (b > a && b > c) {
//     max = b;
// } else if (c > a && c > b) {
//     max = c;
// }

// String res = String.Format("{0} {1} {2} -> {3}", a, b, c, max);

// Console.WriteLine(res);

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.WriteLine("Enter a:");

// int a = Convert.ToInt32(Console.ReadLine());

// String res = a%2 == 0 ? "да" : "нет";

// Console.WriteLine("{0} -> {1}", a, res);

//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// using System;
// using System.Text;
// Console.WriteLine("Enter a:");

// int a = Convert.ToInt32(Console.ReadLine());

// StringBuilder sb = new StringBuilder(String.Format("{0} -> ", a));

// for (int i = 2; i <= a ; i++)
// {
//     if (i%2 == 0){
//         sb.Append(i);
//         sb.Append(", ");
//     }
// }

// String res = sb.ToString();

// if (res.EndsWith(", ")) {
//     int i = res.LastIndexOf(", ");
//     res = res.Substring(0, i);
// } 

// Console.WriteLine(res);
