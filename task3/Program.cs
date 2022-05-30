/*
Задача 49: Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные,
и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4


Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4


*/

int [,] InitMatrix(int firstDemension, int secondDemension)
{
    int [,] matrix = new int[firstDemension, secondDemension];
    Random rnd = new Random();
    for(int i = 0; i < firstDemension; i++)
        {
            for(int j = 0; j < secondDemension; j++)
                matrix[i, j] = rnd.Next(1,20);
        }

    return matrix;
}


int GetDemension(string message)
{
    System.Console.Write(message);
    return int.Parse(System.Console.ReadLine());
}

int[,] GetPov(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                arr[i,j] = arr[i,j] * arr[i,j];
            }
        }
    }
    return arr;
}

void PrintArray(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}  ");
        }
        System.Console.WriteLine();
    }    
}

int firstDemension = GetDemension("Введите размер первого разряда: ");
int secondDemention = GetDemension("Введите размер второго разряда: ");
int[,] arr = InitMatrix(firstDemension,secondDemention);
PrintArray(arr);
Console.WriteLine();
int[,] povArr = GetPov(arr);
PrintArray(povArr);
