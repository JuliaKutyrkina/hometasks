// задача 50. Поиск элемента по его позиции в двумерном массиве. 
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Clear();
int[,] matrix = new int[5, 5];
InputMatrix(matrix);
Console.WriteLine("Начальный массив: ");
PrintMatrix(matrix);
Console.Write("Введите номер строки: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n>5 || m>5 || n<1 ||m<1) Console.Write("Такого элемента не существует, повторите ввод");
else Console.WriteLine(matrix[n-1,m-1]);