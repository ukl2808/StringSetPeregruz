public class Matrix
{
    private int[,] matrix;

    public Matrix(int rows, int columns)
    {
        matrix = new int[rows, columns];
    }

    public int this[int row, int column]
    {
        get { return matrix[row, column]; }
        set { matrix[row, column] = value; }
    }

    public void Print()
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}