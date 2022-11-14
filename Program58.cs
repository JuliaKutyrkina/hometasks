// 58. Задать 2 матрицы и найти их произведение

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }

}

void ResultMatrix(int[,] matrix, int[,] matrix1)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int result = matrix[i, j] * matrix1[i, j];
            Console.Write($"{result} \t");
        }
        Console.WriteLine();
    }

}

Console.Clear();
Console.Write("Введите количество строк и столбцов в исходных матрицах: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
int[,] matrix1 = new int[n, m];
Console.WriteLine("Первая матрица:");
InputMatrix(matrix);
Console.WriteLine("Вторая матрица:");
InputMatrix(matrix1);
Console.WriteLine("Результирующая матрица:");
ResultMatrix(matrix, matrix1);

