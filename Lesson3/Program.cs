/* Напишите программу, которая на вход принимает число и выдает является ли оно четным (делится ли оно на два без остатка)*/

Console.WriteLine("Введите число");
string namberStr = Console.ReadLine();
int number = Convert.ToInt32(namberStr);

if (number % 2 ==0)
{
Console.WriteLine($"число {number} является четным");
}
else
{
  Console.WriteLine($"число {number} является нечетным");  
}