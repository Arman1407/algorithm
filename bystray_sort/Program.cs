// Быстрая сортировка

void main(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 20);
}

void selSort(int[]array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int min = i;
        for(int j = i + 1; j < array.Length; j++)
            if(array[j] < array[min])
            min = j;
        if(min != i)
        {
            int temp = array[min];
            array[min] = array[i];
            array[i] = temp;
        }
    }
}

// ИЛИ
void selSort_2(int[]array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        for(int j = i + 1; j < array.Length; j++)
            if(array[j] < array[i])
            {
                int temp = array[i];
                array[i] = array[i];
                array[i] = temp;
            }

    }
}

// ИЛИ
void selSort_3(int[]array)
{
    for(int j = 1; j < array.Length; j++)
    {
        int value = array[j];
        int i = j - 1;
        for( ; i >= 0; i--)
        {
            if(value < array[i])
                array[i + 1] = array[i];
            else
                break;
        }
        array[i + 1] = value;
    }
        
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
main(array);
Console.WriteLine($"Начальный массив: [{string.Join("; ", array)}]");
selSort(array);
Console.WriteLine($"Конечный массив: [{string.Join("; ", array)}]");
selSort_2(array);
Console.WriteLine($"Конечный массив: [{string.Join("; ", array)}]");
selSort_3(array);
Console.WriteLine($"Конечный массив: [{string.Join("; ", array)}]");