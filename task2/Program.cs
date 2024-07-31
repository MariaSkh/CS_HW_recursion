//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

void Main()
{
    int m = ReadInt("Введите целое неотрицательное цисло: ");
    int n = ReadInt("Введите еще одно целое неотрицательное число: ");

    System.Console.WriteLine(A(m, n));

}

int A(int m, int n)
{
    if (m == 0)
        return n + 1;

    else if (n == 0)
        return A(m - 1, 1);

    else
        return A(m - 1, A(m, n - 1));
}


int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

Main();
