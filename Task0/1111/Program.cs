// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое 
// число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет
// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница
// Console.Write(" Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write(" Введите число второе: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (b*b==a) 
// {
// Console.Write(" Первое число является квадратом второго числа ");
// }
// else 
// { Console.Write(" Первое число не является квадратом второго числа ");
// }
// заработало!!!
Console.WriteLine("Введите переменную а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

