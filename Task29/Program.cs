// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int[] FillArray(int size)
{
    int[] array = new int[size];
    Random rand = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = rand.Next(3, 87);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[^1]}]");
}
int[] massive = FillArray(8); 
PrintArray(massive);