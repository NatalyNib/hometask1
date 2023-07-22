/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное 
из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Write("Enter number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 3: ");
int c = Convert.ToInt32(Console.ReadLine());
int maxi = a;
if(b > maxi)
    maxi = b;
if(c > maxi)
    maxi = c;
Console.WriteLine(maxi);
