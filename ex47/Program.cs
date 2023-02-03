void FillMatrix(double[,] matrix)
{
  for(int i = 0; i < matrix.GetLength(0); i++)
  {
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = Math.Round(new Random().NextDouble() * 10, 2);
      Console.Write($"{matrix[i, j]} \t");

    }
    Console.WriteLine();
  }
}



Console.Clear();
Console.Write("Введите через пробел колличество строк и столбцов в матрице: ");
int[] MatrSize = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[MatrSize[0], MatrSize[1]];
FillMatrix(matrix);
