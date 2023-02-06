// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Console.WriteLine("write a: ");
// String a = Console.ReadLine();
// if(a.Length != 5) throw new System.Exception("len is not 5");
// int ai = int.Parse(a);
// int left = 0;
// int right = a.Length - 1;
// String res = " -> да";
// while (left != right) {
//     if(a[left] != a[right]) {
//         res = " -> нет";
//         break;
//     }
//     left++;
//     right--;
// }
//  Console.WriteLine(a + res);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Console.WriteLine("write a: ");
// String a = Console.ReadLine();
// Console.WriteLine("write b: ");
// String b = Console.ReadLine();
// double pow = 2.0;

// string[] xyzA = a.Trim().Split(",");
// string[] xyzB = b.Trim().Split(",");
// if (xyzA.Length != 3 || xyzB.Length != 3)
//     throw new System.Exception("len is not 3");
// double res = Math.Sqrt(
//     Math.Pow(
//             double.Parse(xyzB[0]) - double.Parse(xyzA[0]), pow
//     ) +
//         Math.Pow(
//             double.Parse(xyzB[1]) - double.Parse(xyzA[1]), pow
//     ) +
//         Math.Pow(
//             double.Parse(xyzB[2]) - double.Parse(xyzA[2]), pow
//     )
// );
// String output = String.Format("A ({}); B ({}), -> {}", a, b, Math.Round(res, 2));

//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Console.WriteLine("write a: ");
// String a = Console.ReadLine();
// int ai = int.Parse(a);
// Console.Write("{} -> ", a);
// for (int i = 1; i <= ai ; i++)
// {
//     Console.Write(Math.Pow(i, 3.0).ToString());
//     if ( i != ai) Console.Write(", ");
// }
