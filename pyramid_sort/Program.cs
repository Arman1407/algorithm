// Пирамидальная сортировка (сортировка кучей)

void sort(int[] array)
{
    for(int i = array.Length / 2 - 1; i >= 0; i--) // разбиваем неотсортированный массив на пары в пирамидальном порядке
        heapify(array, array.Length, i);

    for(int i = array.Length - 1; i>= 0; i--) // проверяем элементы в парах
    {
        int temp = array[0];                    // меняем местами при необходимости (8, 5) --> (5, 8)
        array[0] = array[i];
        array[i] = temp;

        heapify(array, i, 0);       // вызываем процедуру 
    }
}

void heapify(int[] array, int heapSize, int rootIndex)
{
    int largest = rootIndex;                // назначаем корень - наибольший элемент
    int leftChild = 2 * rootIndex + 1;      // назначаем корень в левой части
    int rightChild = 2 * rootIndex + 2;     // назначаем корень в правой части
    
    if(leftChild < heapSize && array[leftChild] > array[largest]) // сортируем левую часть
        largest = leftChild;
    if(rightChild < heapSize && array[rightChild] > array[largest]) // сортируем правую часть
        largest = rightChild;
    if(largest != rootIndex)                // если самый большой элемент не корень, меняем их местами
    {
        int temp = array[rootIndex];
        array[rootIndex] = array[largest];
        array[largest] = temp;

        heapify(array, heapSize, largest);  // рекурсивно преобразуем в двоичную кучу поддерево
    }
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
sort(array);
Console.WriteLine($"Начальный массив: [{string.Join("; ", array)}]");
heapify(array);
Console.WriteLine($"Конечный массив: [{string.Join("; ", array)}]");