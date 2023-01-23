// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(10, 1, 20);
ShowArray(myArray);

int minEl = myArray[0];
int maxEl = myArray[0];

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > maxEl) maxEl = myArray[i];
}
for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] < minEl) minEl = myArray[i];
}

int diff = maxEl - minEl;
Console.WriteLine($"Разница между максимальным и минимальным значением = {diff}");

// Задача 38
// Поиск минимального и максимального элемента можно было проводить в одном цикле, просто последовательно 
// проверять  для каждого элемента больше ли он max, а потом меньше ли он min. 
// Тогда бы программа проходила по массиву один раз, а не два, что ускорило бы ее работу.

// Вы присвоили переменным min и max значение нулевого элемента. 
// Очевидно, что значение нулевого элемента будет равны значениям min и max. 
// Так, зачем тогда сравнивать их в цикле?
//  Можно сразу начать цикл с элемента с индексом 1.
