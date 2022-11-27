// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using static System.Console;
Clear();

WriteLine("Enter 8 digits: ");
int digit1 = Convert.ToInt32(ReadLine());
int digit2 = Convert.ToInt32(ReadLine());
int digit3 = Convert.ToInt32(ReadLine());
int digit4 = Convert.ToInt32(ReadLine());
int digit5 = Convert.ToInt32(ReadLine());
int digit6 = Convert.ToInt32(ReadLine());
int digit7 = Convert.ToInt32(ReadLine());
int digit8 = Convert.ToInt32(ReadLine());

int[] array = new int[] {digit1, digit2, digit3, digit4, digit5, digit6, digit7, digit8};

var str = string.Join(" ", array);
WriteLine($"[{str}]");
