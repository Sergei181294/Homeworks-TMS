using System;

class MatrixProgram
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows in the matrix: ");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of columns in the matrix: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Enter the element of matrix:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.WriteLine($"Element [{i},{j}] is:");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Choose an action:");
        Console.WriteLine("1.Find the count of positive and negative numbers in the matrix:");
        Console.WriteLine("2. Sort elements of the matrix row-wise:");
        Console.WriteLine("3. Invert elements of the matrix row-wise:");

        int item = int.Parse(Console.ReadLine());

        switch (item)
        {
            case 1:
                int positiveNumbers = 0;
                int negativeNumbers = 0;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (matrix[i, j] != 0)
                        {
                            if (matrix[i, j] > 0)
                            {
                                positiveNumbers++;
                            }
                            else
                            {
                                negativeNumbers++;
                            }
                        }
                    }
                }

                Console.WriteLine(positiveNumbers + " positive numbers");
                Console.WriteLine(negativeNumbers + " negative numbers");
                break;

            case 2:
                Console.WriteLine("In descending order:");

                for (int i = 0; i < rows; i++)
                {
                    int[] rowArray = new int[cols];

                    for (int j = 0; j < cols; j++)
                    {
                        rowArray[j] = matrix[i, j];
                    }
                    Array.Sort(rowArray, (a, b) => b.CompareTo(a));

                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(rowArray[j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("In ascending order: ");

                for (int i = 0; i < rows; i++)
                {
                    int[] tempArray = new int[cols];

                    for (int j = 0; j < cols; j++)
                    {
                        tempArray[j] = matrix[i, j];
                    }

                    Array.Sort(tempArray);

                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(tempArray[j] + " ");
                    }
                    Console.WriteLine();
                }
                break;
            case 3:
                Console.WriteLine("Инверсия элементов матрицы:");

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = -matrix[i, j];
                    }

                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                break;
        }
    }
}
