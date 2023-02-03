char[,] InputMatrix(int[] size)
{
  char[,] matrix = new char[size[0], size[1]];
  for(int i =  0; i < matrix.GetLength(0); i++)
  {
    char[] chars = Console.ReadLine().ToArray();
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = chars[j];
    }
  }
  return matrix;
}

void Contrast(char[,] matrix1, char[,] matrix2)
{
  int count = 0;
  for(int i = 0; i < matrix1.GetLength(0); i++)
  {
    for(int j = 0; j < matrix1.GetLength(1); j++)
    {
      if(matrix1[i,j] == matrix2[i,j])
        count++;
    }
  }
  Console.WriteLine($"Неправильно сформированных пикселей негатива: {count}");
}


Console.Clear();
Console.Write("Введите размер изображения: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

Console.WriteLine("Введите пиксели исходного изображения построчно: ");
char[,] photo = InputMatrix(size);
Console.WriteLine("Введите пиксели негатива построчно: ");
char[,] negative = InputMatrix(size);

Contrast(photo, negative);