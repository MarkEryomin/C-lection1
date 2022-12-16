// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

// Console.WriteLine("Введите число ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = -a;
// while (b<=a) 
// {
//     Console.Write(b+", ");
//     b=b+1;
// }


// Console.Write("write number: ");
// int n = Convert.ToInt32(Console.ReadLine());
//     for(int i=-n; i <= n; i++)
//     {
//     Console.WriteLine(" "+ i);
//     }


Console.WriteLine("Введите трёхзначное число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>=100 && a<1000)
{
Console.WriteLine("Последняя цифра");
Console.WriteLine(a%10);
}
else Console.WriteLine("Неверная цифра");



// Console.Write("write number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// if(n < 0)
// {
//     n = -n;
// }
// for(int i=-n; i <= n; i++)
// {
//     Console.Write( i + " ");
// }

