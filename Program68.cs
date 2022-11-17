//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29

int AkkFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m>0 && n == 0)
        return AkkFunction(m - 1, 1);
    else 
        return AkkFunction(m - 1, AkkFunction(m, n - 1));
}

Console.Clear();
Console.WriteLine("Введите неотрицательное число m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите неотрицательное число n:");
int n = Convert.ToInt32(Console.ReadLine());
while (m < 0 || n < 0)
{
    Console.WriteLine("Введите неотрицательное число m:");
    m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите неотрицательное число n:");
    n = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine($"Функция Аккермана для чисел A({m},{n}) = {AkkFunction(m, n)}");
