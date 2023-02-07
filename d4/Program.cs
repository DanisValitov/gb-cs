// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// while (true)
// {
//     Console.WriteLine("write a: ");
//     int a = int.Parse(Console.ReadLine());
//     Console.WriteLine("write b: ");
//     int b = int.Parse(Console.ReadLine());
//     double res = Math.Pow(a, b);
//     String outp = String.Format("{0}, {1} -> {2}", a, b, res);
//     Console.WriteLine(outp);
// }

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.WriteLine("write a: ");
// string inp = Console.ReadLine();
// int a = int.Parse(inp);

// int res = 0;
// foreach (var c in inp)
// {
//     res += int.Parse(c.ToString());
// }

// String outp = String.Format("{0} -> {1}", inp, res);
// Console.WriteLine(outp);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
using System.Text;

Console.WriteLine("write arr with commas: ");
string inp = Console.ReadLine();
StringBuilder sb = new StringBuilder(inp);
sb.Append(" -> [");
var arr = inp.Trim().Split(",");
for (int i = 0; i < arr.Length; i++)
{
    sb.Append(arr[i]);
    if (i != arr.Length - 1) sb.Append(", ");
}

sb.Append("]");

var res = sb.ToString();

Console.WriteLine(res);

