// 62. Задать массив 4*4, заполнить его спирально. 

void InputMatrix(int[,]matrix)
{
    int n = 1; int i = 0; int j = 0;
    while(n <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = n;
        n++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    for(i = 0; i < matrix.GetLength(0); i++)
    {
        for(j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine("");
    }
}
Console.Clear();
int[,] matrix = new int [4,4];
InputMatrix(matrix);