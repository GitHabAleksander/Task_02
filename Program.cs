// Задача 4: Напишите программу, которая принимает на вход
//  три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Add first number:");
string? numberStringA = Console.ReadLine();
int numberA = Convert.ToInt32(numberStringA);
Console.WriteLine("Add second number:");
string? numberStringB = Console.ReadLine();
int numberB = Convert.ToInt32(numberStringB);
Console.WriteLine("Add third number:");
string? numberStringC = Console.ReadLine();
int numberC = Convert.ToInt32(numberStringC);
int max = 0;
if (numberA > numberB)
{
    max = numberA;
}    
if (numberC > numberA)
{
    max = numberC;
}
if (numberB > numberC)
{
    max = numberB;
} 
Console.Write("Max:");
Console.WriteLine(max);