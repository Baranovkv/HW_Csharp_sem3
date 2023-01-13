// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности
// и проверяет, является ли оно палиндромом.

int [] NumberArray(int num) // ФУНКЦИЯ СОЗДАНИЯ И ВОЗВРАТА МАССИВА ИЗ ЦИФР ЧИСЛА
{
    num = Math.Abs(num); // получаем модуль числа, чтобы работало с отрицательными числами
    int count = 0;
    for (int i = num; i > 0; i = i / 10) count++; // считаем разрядность введенного числа в переменную count
    int [] array = new int [count]; // создаем массив с разрядностью числа
    for (int i = count-1; i >= 0; i--) // заполняем массив с конца путем сохранения остатков от деления числа на 10
    {
        array[i] = num % 10;
        num = num / 10;
    }
    return array;
}

bool Palindrome(int [] pal) // функция проверки числа, является ли оно полиндромом
{
    bool isPal = false;
    for (int i = 0; i < pal.Length/2; i++) // сравниваем первый элемент с последним, второй с предпоследним и далее
    {
        if (pal[i] == pal[pal.Length-1-i]) 
            isPal = true;
        else
        {
            isPal = false;
            break; // если хотя бы один раз встречаем неодинаковые элементы - конец цикла, число не палендром
        }
    }
    return isPal;
}

Console.WriteLine("Please enter a number");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Palindrome(NumberArray(number)));