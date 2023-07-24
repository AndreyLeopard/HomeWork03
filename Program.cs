int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}



//  Урок 3. Базовые алгоритмы. Продолжение
void Task19()
{
    /* Задача 19
    Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    14212 -> нет
    12821 -> да
    23432 -> да */

    int number = Input("Введите число: ");
    // string numberStr = Convert.ToString(number);

    //if (numberStr[0] == numberStr[4] && numberStr[1] == numberStr[3])
    if (number/10000 == number%10 
        && number/1000%10 == number/10%10)
    {
        Console.WriteLine($"Число {number} палиндром");
    }
    else
    {
        Console.WriteLine($"Число {number} НЕ палиндром");
    }
}

void Task21()
{
/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
    
    int x1 = Input("Введите число x1: ");
    int y1 = Input("Введите число y1: ");
    int z1 = Input("Введите число z1: ");

    int x2 = Input("Введите число x2: ");
    int y2 = Input("Введите число y2: ");
    int z2 = Input("Введите число z2: ");

    double result = Math.Sqrt( Math.Pow(x2 -x1,2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    result = Math.Round(result, 3);
    Console.WriteLine(result);
}


/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();
Task21();
