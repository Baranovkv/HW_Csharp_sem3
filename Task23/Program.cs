// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Please enter a number");
int number = Convert.ToInt32(Console.ReadLine());

void Rais3Pow(int n)
{
    int index = 1;
    while (index <= n)
    {
        Console.WriteLine($"{index} to the third power is {Math.Pow(index, 3)}");
        index++;
    }
}
Rais3Pow(number);