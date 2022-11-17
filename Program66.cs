//66. Введите числа m и n. Просчитать сумму чисел, лежащих в промежутке между ними. 

int ResultNumbers(int m, int n)
{
    if (m == n)
        return m;
    if (m<n)
        return ResultNumbers(m + 1, n) + m;
    return ResultNumbers (m-1, n)+m;
}

Console.Clear();
Console.WriteLine(" Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел в промежутке между {m} и {n} составляет: {ResultNumbers(m, n)}");
