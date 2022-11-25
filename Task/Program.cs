// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int SizeArray(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) size++;
    }
    return size;
}

void SelectElement(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\"{array[i]}\" ");
    }
    Console.WriteLine();
}

Console.WriteLine("Массив строк: ");
string[] array1 = { "1234", "world", "+5", "923", "hello", ":-)" };
PrintArray(array1);
int sizeArray = SizeArray(array1);
string[] array2 = new string[sizeArray];
SelectElement(array1, array2);
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа: ");
PrintArray(array2);