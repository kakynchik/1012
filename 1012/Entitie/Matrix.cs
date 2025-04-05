namespace _1012.Entitie;

public class Matrix
{
    public int Rows { get; set; }
    public int Columns { get; set; }
    public double[,] Values { get; set; }

    public Matrix(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        Values = new double[rows, columns];
    }

    public Matrix(int rows, int columns, double[,] values)
    {
        Rows = rows;
        Columns = columns;
        Values = values;
    }

    public double this[int row, int column]
    {
        get => Values[row, column];
        set => Values[row, column] = value;
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Columns != b.Columns)
        {
            throw new InvalidOperationException("Matrices must have the same dimensions.");
        }

        var result = new Matrix(a.Rows, a.Columns);

        for (var i = 0; i < a.Rows; i++)
        {
            for (var j = 0; j < a.Columns; j++)
            {
                result[i, j] = a[i, j] + b[i, j];
            }
        }

        return result;
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Columns != b.Columns)
        {
            throw new InvalidOperationException("Matrices must have the same dimensions.");
        }

        var result = new Matrix(a.Rows, a.Columns);

        for (var i = 0; i < a.Rows; i++)
        {
            for (var j = 0; j < a.Columns; j++)
            {
                result[i, j] = a[i, j] - b[i, j];
            }
        }

        return result;
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.Columns != b.Rows)
        {
            throw new InvalidOperationException(
                "The number of columns in the first matrix must be equal to the number of rows in the second matrix.");
        }

        var result = new Matrix(a.Rows, b.Columns);

        for (var i = 0; i < a.Rows; i++)
        {
            for (var j = 0; j < b.Columns; j++)
            {
                for (var k = 0; k < a.Columns; k++)
                {
                    result[i, j] += a[i, k] * b[k, j];
                }
            }
        }

        return result;
    }

    public static bool operator ==(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Columns != b.Columns)
        {
            return false;
        }

        for (var i = 0; i < a.Rows; i++)
        {
            for (var j = 0; j < a.Columns; j++)
            {
                if (a[i, j] != b[i, j])
                {
                    return false;
                }
            }
        }

        return true;
    }

    public static bool operator !=(Matrix a, Matrix b)
    {
        return !(a == b);
    }

    public override string ToString()
    {
        return $"Matrix ({Rows}x{Columns})";
    }
}