// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Console.Clear();
//Console.Write("Введите число:");

//int number = Convert.ToInt32(Console.ReadLine());
//int sqrt = number * number;
// number *= number 
//Convert.ToInt32(Math.Pow(number,2)); 
//Console.Write("Число в квадрате: " + sqrt );


// 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

//Console.Write("Input first number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Input second number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());
//if (num1 == num2 * num2)
//    Console.Write("First number is a square of second number");
//else
//    Console.Write("First number is not a square of second number");


// 3 Напишите программу, которая будет выдавать название дня недели по заданному номеру

Console.Write("Input number of the day: ");

int day = Convert.ToInt32(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.Write("Incorrect number");
}
else
{
    if (day == 1)
    {
        Console.Write("Monday");
    }
    if (day == 2)
    {
        Console.Write("Tuesday");
    }
}





