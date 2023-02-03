void FillMatrix(int[,] matrix)
{
  for(int i = 0; i < matrix.GetLength(0); i++)
  {
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
      if (i == 0)
      {
        if ( j == 0)
          matrix[i, j] = 0;
        else if(j < matrix.GetLength(0))
          matrix[i, j] = j + matrix[i, j - 1];
        else 
          matrix[i,j] = matrix[i, j - 1] + matrix.GetLength(0);        
      }
      else if ( j == matrix.GetLength(1) - 1)
        matrix[i, j] = matrix[i - 1, j] + (matrix.GetLength(0) - (i - 1));
      else
        matrix[i, j] = matrix[i - 1, j + 1] + 1;
    Console.Write($"{matrix[i,j]}  \t");
    }
    Console.WriteLine();
  }
}







Console.Clear();
Console.Write("Введите размер массива через пробел: ");
int [] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0],size[1]];
FillMatrix(matrix);