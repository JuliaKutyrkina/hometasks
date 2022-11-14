//56. В двумерном массиве целых чисел найти строку с наименьшей суммой элементов
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 6);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void ReleaseMatrix(int[,] matrix)
{
    int[] sumRow = new int [matrix.GetLength(0)];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow[i] += matrix[i,j];
        }
    } 
   int minRow = sumRow[0];
   int rowNumber = 0;
   for (int i = 0; i<sumRow.GetLength(0); i++)
   {
    if (sumRow[i]<minRow)
    {
       minRow=sumRow[i];
       rowNumber = i+1;
    } 
   }
    Console.WriteLine ($"Наименьшая сумма элементов найдена в строке " + rowNumber + " и равна " + minRow); 
}


Console.Clear();
Console.Write("Введите кол-во строк и столбцов: ");
string[] num = Console.ReadLine().Split(' ');
int n = int.Parse(num[0]);
int m = int.Parse(num[1]);
int[,] matrix = new int[n, m];
Console.WriteLine("Начальный массив: \n");
InputMatrix(matrix);
ReleaseMatrix(matrix);

