// 60. Задать трехмерную матрицу 2*2*2, заполненную 2-значными неповторяющимися числами. Написать программу построчного вывода матрицы
// с индексами элементов.

void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                matrix[i,j,k]= new Random().Next(10,100);
                Console.Write($"{matrix[i,j,k]}({i},{j},{k}) \t ");
            }
        Console.WriteLine();    
        }
    }

}



Console.Clear();
int[,,] matrix = new int[2,2,2];
InputMatrix(matrix);

