// Задача 1: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

void Main ()
{
    int M = ReadInt("Введите первое значение: ");
    int N = ReadInt("Введите второе значение: ");

    if (M >= N)
    {
        System.Console.WriteLine("Первое значение должно быть больше второго");
        return; 
    }
        
    
    ShowDigits(M, N);
}

void ShowDigits (int M, int N)
{
    if (M > N) return;

    else if (M < N)
    {
        System.Console.Write(M + ", ");
        ShowDigits(M + 1, N);   
    }

    else 
    {
        System.Console.Write(M);
        ShowDigits(M + 1, N); 
    }
}

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
