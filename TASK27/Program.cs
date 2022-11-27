// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;
Clear();

int SumofdigitsinNumber (int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum += num % 10;
        num /=10;   
    }
return sum;
}

WriteLine("Enter Number: ");
int number = Convert.ToInt32(ReadLine());
WriteLine($"Sum of all digits in number = {SumofdigitsinNumber(number)}");
