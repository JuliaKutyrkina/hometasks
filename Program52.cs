// задача 52. Найти среднеарифметическое каждого столбца в двумерном массиве
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ColsAvg (int[,] matrix)
{
    for (int j = 0; j< matrix.GetLength(1); j++)
    {
        double ColsAvg = 0;
        for (int i = 0;i < matrix.GetLength(0); i++)
        {                  
            ColsAvg += matrix[i,j];
        }
        ColsAvg = Math.Round(ColsAvg / matrix.GetLength(0),2);
        Console.Write("Среднеарифметическое столбца {0}: {1}", j, ColsAvg);         
    }
}


Console.Clear();
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
ColsAvg(matrix);
