// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void User (int number)
// {
//     if 
//     (number / 10000 == number %10 && (number / 1000)%10 == (number %100)/10 )
//     System.Console.WriteLine("The number is a palindrome");
//     else if (number > 99999) 
//     {System.Console.WriteLine("Write five-digit number");}
//     else if (number < 10000) {System.Console.WriteLine("Write five-digit number");}
//     else
//     System.Console.WriteLine("The number is a not palindrome");
// }
// System.Console.WriteLine("Write number");
// int numb = Convert.ToInt32(Console.ReadLine());
// User(numb);

// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Question (double X1, double Y1, double Z1, double X2, double Y2, double Z2)
// {
//     double answer =Math.Sqrt(Math.Pow (X2-X1,2)+Math.Pow(Y2-Y1,2)+Math.Pow(Z2-Z1,2));
//     return answer;
// }
// System.Console.WriteLine("Write x1");
// int x1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Write y1");
// int y1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Write z1");
// int z1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Write x2");
// int x2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Write y2");
// int y2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Write z2");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double threeD = Question (x1, y1, z1, x2, y2, z2);
// System.Console.WriteLine($"Result {Math.Round(threeD,2)}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Question (int number)
// {
// for (int numb = 1; numb <= number; numb++)
// System.Console.Write(Math.Pow(numb,3) +" ");
// }
// System.Console.WriteLine("Write number");
// int user = Convert.ToInt32(Console.ReadLine());
// Question (user);