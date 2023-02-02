// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Методы ******************************************

int chkArrEntriesPosOrNeg(double[] array, bool moreOrLess) //считает количество эл-тов (moreOrLess -true)> 0 (moreOrLess -false)< 0 
{
    int result = 0;
    for (int i = 0; i < array.Length; i++) if (array[i] != 0) if (!(array[i] > 0 ^ moreOrLess)) result++;
    return result;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

double[] GetInfiniteArray() // Принимает ввод массива любой длины
{
    List<double> MyList = new List<double>();
    double n = 0;
    string answer = string.Empty;
    Console.WriteLine("Вводим число, давим Enter. Вводим следующее.. Когда надоест, введите не число и ввод закончится");
    while (true)
    {
        Console.Write("Вводите следующее число: ");
        if (Double.TryParse(Console.ReadLine(), out n))
        {
            MyList.Add(n);
        }
        else
        {
            Console.WriteLine("Выходим y/n?");
            answer = Console.ReadLine();
            if (answer == "y" || answer == "Y") break;

        }

    }
    Console.WriteLine("Ввод закончен");

    return MyList.ToArray();
}

// Основная программа********************************************************

double[] MyArr = GetInfiniteArray();

PrintArray(MyArr);

Console.WriteLine();

Console.WriteLine("Количество элементов больше нуля:" + chkArrEntriesPosOrNeg(MyArr, true));
Console.WriteLine("Количество элементов меньше нуля:" + chkArrEntriesPosOrNeg(MyArr, false));

