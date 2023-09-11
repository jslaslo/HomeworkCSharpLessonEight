// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int[,] array = SpiralArray(4, 4);
PrintArray(array);

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
}
int[,] SpiralArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int assigner = 1;
    int upI = 0;
    int downI = 0;
    int leftJ = 0;
    int rightJ = 0;
    int i = 0;
    int j = 0;
    while (assigner <= rows * columns)
    {
        array[i, j] = assigner;
        if (i == upI && j < columns - rightJ - 1) ++j;
        else if (j == columns - rightJ - 1 && i < rows - downI - 1) ++i;
        else if (i == rows - downI - 1 && j > leftJ) --j;
        else --i;
        if (i == upI + 1 && j == leftJ && leftJ != columns - rightJ - 1)
        {
            upI++;
            downI++;
            leftJ++;
            rightJ++;
        }
        assigner++;
    }
    return array;
}