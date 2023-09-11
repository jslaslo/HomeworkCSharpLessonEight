// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] matrixOne = FillMatrix(2,2);
PrintMatrix(matrixOne);
int[,] matrixTwo = FillMatrix(2,2);
PrintMatrix(matrixTwo);
int[,] resultMatrix = MultiplicationMatrix(matrixOne, matrixTwo);
PrintMatrix(resultMatrix);

static int[,] MultiplicationMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] resultMatrix = new int[matrixOne.GetLength(0), matrixOne.GetLength(1)];
    for (int i = 0; i < matrixOne.GetLength(0); i++)//Проход по строкам matrixOne
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)//Проход по столбцам matrixTwo
        {
            for (int k = 0; k < matrixOne.GetLength(1); k++)//Дополнительный цикл для прохода по столбцам у matrixOne и по строкам matrixTwo
            {
                resultMatrix[i, j] += matrixOne[i, k] * matrixTwo[k, j];
            }            
        }
    }
    return resultMatrix;
}

static int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    Random random = new();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(-10, 11);
        }
    }
    return matrix;
}
static void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write("| " + matrix[i, j] + "\t");
        }
        System.Console.Write("|");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
    
}