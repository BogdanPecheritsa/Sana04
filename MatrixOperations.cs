using System;

public class MatrixOperations
{
    public int[,] IntMatrix { get; private set; }

    public MatrixOperations(int rows, int columns)
    {
        Random rand = new Random();

        IntMatrix = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                IntMatrix[i, j] = rand.Next(-100, 100);
            }
        }
    }
}