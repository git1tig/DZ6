// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


// МЕТОДЫ *******************************************************
double[] fillArray(int n, string arrName)
{
    double[] array = new double[n];
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine($"Введите  {arrName}{i + 1}");
        while (!double.TryParse(Console.ReadLine(), out array[i]))
        {
            Console.WriteLine("Ввод неверный. Пожалуйста, введите число");
        }
    }
    return array;
}

//ОСНОВНАЯ ПРОГРАММА**********************************************

double[] k = fillArray(2, "k");
double[] b = fillArray(2, "b");
double x = (b[1] - b[0]) / (k[0] - k[1]);
double y = k[1] * x + b[1];
Console.WriteLine("Считаем...");
if (k[0]!=k[1]) Console.WriteLine($"При таких k1,k2,b1,b2 точкой пересечения будет ({x} , {y})");
else Console.WriteLine("Такие прямые не пересекаются!");


