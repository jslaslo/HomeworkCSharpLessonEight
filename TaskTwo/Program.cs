// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых 
// расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
int[,] array = FillArray(4, 4);
PrintArray(array);
array = GetSlicedArray(array);
PrintArray(array);

int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


int SearchMinimum(int[,] array)
{
    int minValue = int.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minValue > array[i, j])
            {
                minValue = array[i, j];
            }
        }
    }
    return minValue;
}
int[,] GetSlicedArray(int[,] array)
{
    int minValue = SearchMinimum(array);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minValue == array[i, j])
            {
                return Slice(i, j, array);
            }
        }
    }
    return array;
}
int[,] Slice(int row, int column, int[,] array)
{
    int columnsLenght = array.GetLength(1) - 1;
    int rowsLenght = array.GetLength(0) - 1;
    int countColumn = 0;
    int countRow = 0;
    int[,] slisedArray = new int[rowsLenght, columnsLenght];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != row && j != column)
            {

                slisedArray[countRow, countColumn] = array[i, j];
                countColumn++;
                if (countColumn == columnsLenght)
                {
                    countRow++;
                }
            }
        }
        countColumn = 0;
    }
    return slisedArray;

}