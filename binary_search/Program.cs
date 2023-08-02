// Бинарный поиск
// находим место цифры в массиве, т.е. индекс этого числа

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

int binSesrch(int[] array, int value)
{
    return binaSesrch(array, value, 0, array.Length - 1);
}

int binaSesrch(int[] array, int value, int left, int right)
{
    if(right < left)
        return - 1;
    int mid = (left + right) / 2;
    if(array[mid] > value)
        return binaSesrch(array, value, left, mid - 1);
    else if(array[mid] < value)
        return binaSesrch(array, value, mid + 1, right);
    else
        return mid;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
main(array);
Console.WriteLine($"Начальный массив: [{string.Join("; ", array)}]");
selSort(array);
Console.WriteLine($"Конечный массив: [{string.Join("; ", array)}]");

Console.WriteLine(binSesrch(array, 10));
