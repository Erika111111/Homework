/*Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел*/

Console.Write("Введите число 1");
string input0 = Console.ReadLine();
Console.Write("Введите число 2");
string input1 = Console.ReadLine();
Console.Write("Введите число 3");
string input2 = Console.ReadLine();
int numfirst = Convert.ToInt32(input0);
int numsecond = Convert.ToInt32(input1);
int numthird = Convert.ToInt32(input2);
int max = numfirst;

if (numsecond > numfirst)
{
  max = numsecond;
}  

if (numthird > numsecond)
{
    max = numthird;
}

Console.WriteLine($"максимальным числом является {max}");