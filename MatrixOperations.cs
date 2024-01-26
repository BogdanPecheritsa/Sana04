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
    public int RowsWithoutZerosCount()
    {
        int count = 0;
        int rows = IntMatrix.GetLength(0);
        int columns = IntMatrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            bool hasZero = false;

            for (int j = 0; j < columns; j++)
            {
                if (IntMatrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }

            if (!hasZero)
            {
                count++;
            }
        }

        return count;
    }
    public int ColumnsWithZeroElementCount()
    {
        int count = 0;
        int rows = IntMatrix.GetLength(0);
        int columns = IntMatrix.GetLength(1);

        for (int j = 0; j < columns; j++)
        {
            bool hasZero = false;

            for (int i = 0; i < rows; i++)
            {
                if (IntMatrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }

            if (hasZero)
            {
                count++;
            }
        }

        return count;
    }
    public int LongestSeriesRowNumber()
    {
        int rows = IntMatrix.GetLength(0);
        int columns = IntMatrix.GetLength(1);

        int maxLength = 0;
        int currentLength = 1;
        int rowNumber = 0;

        for (int i = 0; i < rows; i++)
        {
            currentLength = 1;

            for (int j = 1; j < columns; j++)
            {
                if (IntMatrix[i, j] == IntMatrix[i, j - 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                        rowNumber = i;
                    }

                    currentLength = 1;
                }
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                rowNumber = i;
            }
        }

        return rowNumber;
    }
    public int ProductOfNonNegativeRows()
    {
        int rows = IntMatrix.GetLength(0);
        int columns = IntMatrix.GetLength(1);

        int product = 1;

        for (int i = 0; i < rows; i++)
        {
            bool hasNegative = false;

            for (int j = 0; j < columns; j++)
            {
                if (IntMatrix[i, j] < 0)
                {
                    hasNegative = true;
                    break;
                }
            }

            if (!hasNegative)
            {
                for (int j = 0; j < columns; j++)
                {
                    product *= IntMatrix[i, j];
                }
            }
        }

        return product;
    }
    public int MaxSumDiagonals()
    {
        int rows = IntMatrix.GetLength(0);
        int columns = IntMatrix.GetLength(1);

        int maxSum = int.MinValue;

        for (int d = 0; d < rows + columns - 1; d++)
        {
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i + j == d)
                    {
                        sum += IntMatrix[i, j];
                    }
                }
            }

            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }

        return maxSum;
    }
}