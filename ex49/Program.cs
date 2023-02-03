int[,] CreateArray(int[] arr)
{
  int[,] array = new int[arr[0], arr[1]];
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = new Random().Next(0,10);
      Console.Write($"{array[i,j]} \t");
    }
    Console.WriteLine();
  }
  return array;
}
void FindElem(int[,] array, int[] index)
{
  if (index[0] >= array.GetLength(0) || index[1] >= array.GetLength(1) || index[0] < 0 || index[1] < 0)
    Console.WriteLine("Такого элемента в данном массиве нет");
  else
    Console.WriteLine($"Ваш элемент: {array[index[0],index[1]]}");
}


Console.Clear();
int[] ArrSize = new int[2];
for(int i =0; i < ArrSize.Length; i++)
{
  ArrSize[i] = new Random().Next(3,10);
}

int[,] WorkArray = CreateArray(ArrSize);
Console.Write("Введите через пробел индекс элемента: ");
int[] index = Console.ReadLine().Split().Select(x => int.Parse(x) - 1).ToArray(); // приводим идекс к исчислению от 0
FindElem(WorkArray, index);
