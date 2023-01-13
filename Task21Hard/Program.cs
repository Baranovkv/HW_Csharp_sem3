// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.


double[] FillArray(int length) // функция для заполнения массива из чисел с плавающей точкой
{
    double[] array = new double [length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Coordinate {i+1} = ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

double EuclidDistance(double[] firstP, double[] secP, int n) // функция для поиска расстояния Эвклида
{
    double temp = 0;
    for (int i = 0; i < n; i++) // цикл по количеству измерений
        temp = temp + Math.Pow((firstP[i] - secP[i]), 2); // складываем квадраты разницы координат точек
    double result = Math.Sqrt(temp);
    return result;
}

Console.WriteLine("Please enter the number of dimensions");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the coordinates of the first point");
double[] firstPoint = FillArray(N);
Console.WriteLine("Please enter the coordinates of the second point");
double[] secondPoint = FillArray(N);
Console.WriteLine($"The distance between entered pionts is {Math.Round(EuclidDistance(firstPoint, secondPoint, N), 2)}");