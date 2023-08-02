// Сортировка вставками
// делит массив на две половины, перегоняет в левую часть минимальльные значения, в правую - максимальные относительно средней 
// цифры - ЯКОРЯ. Потом сортирует в левой и правой половине массива.


void main(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 20);
}

void quickSort(int[]array)
{
    quicSort(array, 0 , array.Length - 1);
}

void quicSort(int[]array, int leftBorder, int rightBorder)
{
    int leftMarker = leftBorder; 
    int rightMarker = rightBorder;
    int pivot = array[(leftMarker + rightMarker) / 2];
    while(leftMarker <= rightMarker)
        {
            while(array[leftMarker] < pivot)
                leftMarker++;
            while(array[rightMarker] > pivot)
                rightMarker--;
            if(leftMarker <= rightMarker)
            {
                if(leftMarker != rightMarker)
                {
                    int temp = array[leftMarker];
                    array[leftMarker] = array[rightMarker];
                    array[rightMarker] = temp;
                }
                leftMarker++;
                rightMarker--;
            }
        }
        if(leftMarker < rightBorder)
            quicSort(array, leftMarker, rightBorder);
        if(leftBorder < rightMarker)
            quicSort(array, leftBorder, rightMarker);
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
main(array);
Console.WriteLine($"Начальный массив: [{string.Join("; ", array)}]");
quickSort(array);
Console.WriteLine($"Конечный массив: [{string.Join("; ", array)}]");