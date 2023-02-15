//  Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


System.Console.WriteLine();
Console.Write("Массив:");
System.Console.WriteLine();
int[] array = GetArray(8,100,1000); // размер, мин и макс значения
int i = 0;
int[]GetArray (int size, int minValue, int maxValue)
{
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
    {
      res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

void sum(int[]arr)
{
  int count=0;
  for (i=0; i < arr.Length; i++)
    if (i%2>0)
       {
        count=count+arr[i];
       }
    Console.WriteLine($"Cумма элементов, стоящих на нечетных позициях : {arr[1]} + {arr[3]} + {arr[5]} + {arr[7]} = {count}");
}
Console.WriteLine(String.Join(" ", array));
sum(array);
