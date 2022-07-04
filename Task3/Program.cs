//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int  RandomNum()
{
    int a = new Random().Next( Int32.MinValue,  Int32.MaxValue);
    return a;
}


int[] NewArray(int length)
{
    int[] arr = new int[length];
    int i = 0;
    while (i < length)
    {
        arr[i] = RandomNum();
        System.Console.Write(" " + arr[i] + " ");
        i++;
    }
    return arr;
}

void Print(int[] array)
{
    System.Console.WriteLine();
    System.Console.Write("[");
    System.Console.Write(array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
    System.Console.WriteLine("]");
}
int[] array1 = NewArray(8);
Print(array1);
