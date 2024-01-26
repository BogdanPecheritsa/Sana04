bool validInput = false;

do
{
    try
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        MatrixOperations matrixOps = new MatrixOperations(rows, columns);

        int[,] matrix = matrixOps.IntMatrix;
        Console.WriteLine("Generated Integer Matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nCount of positive elements in integer matrix: {matrixOps.CountPositiveElements()}");
        Console.WriteLine($"Max repeating element: {matrixOps.MaxRepeatingElement()}");
        Console.WriteLine($"Rows without zeros count: {matrixOps.RowsWithoutZerosCount()}");
        Console.WriteLine($"Columns with at least one zero element count: {matrixOps.ColumnsWithZeroElementCount()}");
        Console.WriteLine($"Longest series row number: {matrixOps.LongestSeriesRowNumber()}");
        Console.WriteLine($"Product of non-negative rows: {matrixOps.ProductOfNonNegativeRows()}");
        Console.WriteLine($"Max sum of diagonals: {matrixOps.MaxSumDiagonals()}");
        Console.WriteLine($"Sum of columns without negatives: {matrixOps.SumOfColumnsWithoutNegatives()}");
        Console.WriteLine($"Min sum of diagonals: {matrixOps.MinSumOfDiagonals()}");
        Console.WriteLine($"Sum of columns with negatives: {matrixOps.SumOfColumnsWithNegatives()}");

        int[,] transposedMatrix = matrixOps.Transpose();
        Console.WriteLine("\nTransposed Matrix:");
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.Write($"{transposedMatrix[i, j]} \t");
            }
            Console.WriteLine();
        }

        validInput = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("Error! Please enter valid numeric values.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
} while (!validInput);

Console.WriteLine("Program continues...");