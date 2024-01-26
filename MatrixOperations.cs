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
    public int CountPositiveElements()
    {
        int count = 0;
        int rows = IntMatrix.GetLength(0);
        int columns = IntMatrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (IntMatrix[i, j] > 0)
                {
                    count++;
                }
            }
        }

        return count;
    }
    public int MaxRepeatingElement()
    {
        var dict = new Dictionary<int, int>();
        int rows = IntMatrix.GetLength(0);
        int columns = IntMatrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                int currentElement = IntMatrix[i, j];

                if (dict.ContainsKey(currentElement))
                {
                    dict[currentElement]++;
                }
                else
                {
                    dict[currentElement] = 1;
                }
            }
        }

        var maxRepeatingElement = dict.Where(KeyValuePair => KeyValuePair.Value > 1).OrderByDescending(KeyValuePair => KeyValuePair.Value).FirstOrDefault();
        return maxRepeatingElement.Key;
    }
}
