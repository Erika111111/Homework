/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N*/

Console.WriteLine("Введите число");
string namberStr = Console.ReadLine();
int number = Convert.ToInt32(namberStr);

for (int i = 1; i <= number; i++)
    if (i % 2 == 0)
{
    Console.Write(i+ " ");
}

