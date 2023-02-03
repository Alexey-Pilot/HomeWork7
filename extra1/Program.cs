int[,] CreateMatrix(int[] Size)
{
  int[,] matrix = new int[Size[0],Size[1]];
  for(int i = 0; i < matrix.GetLength(0); i ++)
  {
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = new Random().Next(0, 10);
      Console.Write($"{matrix[i,j]} \t");
    }   
    Console.WriteLine();
  }
  return matrix;
}

void InvertMatrix(int[,] matrix)
{
  for(int i = 0; i < (matrix.GetLength(0) / 2); i++)
  {
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
      int tempo = matrix[i, j];
      matrix[i, j] = matrix[matrix.GetLength(0) - 1 - i, j];
      matrix[matrix.GetLength(0) - 1- i, j] = tempo;
    }
  }
}

void PrintMatrix(int[,] matrix)
{
  for(int i = 0; i < matrix.GetLength(0); i++)
  {
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i,j]} \t");
    }
    Console.WriteLine();
  }
}

Console.Clear();
Console.Write("Введите через пробел размеры матрицы: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] WorkMatrix = CreateMatrix(size);
Console.WriteLine();
InvertMatrix(WorkMatrix);
PrintMatrix(WorkMatrix);