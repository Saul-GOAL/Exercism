public class SpiralMatrix
{
    public static int[,] GetMatrix(int size)
    {
        int[,] matrix = new int[size, size];

        int col = 0, row = 0, max = size - 1, min = 0;

        for (int i = 1; i <= size * size; i++)
        {
            matrix[row, col] = i;

            if (row == max && col != min)
                col--;
            else if (col == max)
                row++;
            else if (row == min)
                col++;
            else if (col == min && row != min + 1)
                row--;
            else
            {
                max -= 1;
                min += 1;
                col++;
            }
        }
        return matrix;
    }
}