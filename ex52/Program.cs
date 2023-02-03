int[,] CreateArray()
{
  int [] size = new int[2];
  for(int i = 0; i < size.Length; i++)
    size[i] = new Random().Next(3, 10);
  int [,] Array =new int[size[0], size[1]];
  for(int i = 0; i < Array.GetLength(0); i++)
  {
    for(int j = 0; j < Array.GetLength(1); j++)
    {
      Array[i,j] = new Random().Next(0, 10);
      Console.Write($"{Array[i, j]} \t");
    }
    Console.WriteLine();
  }
  return Array;
}

void ArithmeticMean(int[,] Array)
{
  double[] mean = new double[Array.GetLength(1)];
  for(int i = 0; i < Array.GetLength(1); i++)
  {
    for(int j = 0; j < Array.GetLength(0); j++)
    {
      mean[i] += Array[j, i];
    }
    mean[i] = Math.Round(mean[i] / Array.GetLength(0), 2);
  } 
  Console.WriteLine("Среднее арифметическое в столбиках: ");
  Console.WriteLine(string.Join("\t", mean));
}




Console.Clear();
int[,] WorkArray = CreateArray();
ArithmeticMean(WorkArray);