//54 Задать двумерный массив. Упорядочить по убыванию элементы в каждой строке массива.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write(matrix[i, j]+ " \t");
        }
        Console.WriteLine();
    }
}
void ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1)-1; k++)
            {
                if (matrix[i, k] < matrix[i, k+1])
                {
                    int temp = matrix[i, k+1];
                    matrix[i, k +1] = matrix[i, k];
                    matrix[i, k] = temp;
                }

            }
            Console.Write(matrix[i,j]+" \t");
        
        }
    Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
Console.WriteLine("Начальный массив: ");
InputMatrix(matrix);
Console.WriteLine("Конечный массив: ");
ReleaseMatrix(matrix);

