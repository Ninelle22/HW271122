// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using static System.Console;
Clear();
WriteLine("Enter number: ");
WriteLine("Enter exponentiation number: ");
double number1 = Convert.ToDouble(ReadLine());
double number2 = Convert.ToDouble(ReadLine());
WriteLine(Math.Pow(number1, number2));



