//Задача 3: Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

void Main()
{
    int size = ReadInt ("Введите размер массива: ");
    int minValue = ReadInt ("Введите минимальное значение: ");
    int maxValue = ReadInt ("Введите максимальное значение: ");

    int [] array = GenerateArray(size, minValue, maxValue);

    PrintArray(array); // чтобы проверить, что с помощью рекурсии массив действительно выведен в обратном порядке.
    
    int i = 0;
    PrintReverseArray(array, i);
}


void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
        System.Console.Write(array[i] + ", ");
    
    System.Console.WriteLine(array[array.Length-1]);
}

void PrintReverseArray (int[] array, int i)
{

    if (i >= array.Length) return;

    else if (i == 0)
    {
        PrintReverseArray(array, i + 1);
        System.Console.Write(array[i]);
    }
    
    else
    {
        PrintReverseArray(array, i + 1);
        System.Console.Write(array[i] + ", ");
    }
}


Random rand = new Random();

int[] GenerateArray (int size, int minValue, int maxValue)
{
    int[] array = new int [size];

    for (int i = 0; i < size; i++)
        array[i] = rand.Next(minValue, maxValue + 1);

    return array;
}

int ReadInt (string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
Main();
