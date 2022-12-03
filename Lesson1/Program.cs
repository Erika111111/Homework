/*Напишите программу, которая на вход принимает два числа и выводит, какое число больше, а какое меньше*/

Console.WriteLine("Введите число 1");
string input0 = Console.ReadLine();
Console.WriteLine("Введите число 2");
string input1 = Console.ReadLine();
int numfirst = Convert.ToInt32(input0);
int numsecond = Convert.ToInt32(input1);
int max = numfirst;

if (numfirst > numsecond)
{
  Console.WriteLine ($"Число {numfirst} является большим, а число {numsecond} является меньшим");  
}  
else 
{
    Console.WriteLine ($"Число {numsecond} является большим, а число {numfirst} является меньшим");
}
