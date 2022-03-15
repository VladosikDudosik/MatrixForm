using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Matrix 
{
    public int[,] ArrayMatrix { get; private set; }
    public string StrMatrix
    {
        get
        {
            string str = "";
            for(int i = 0;i < ArrayMatrix.GetLength(0); i++)
            {
                for(int j = 0; j < ArrayMatrix.GetLength(1); j++)
                {
                    str += ArrayMatrix[i,j] + " ";
                }
                str += "\r\n";
            }
            return str;
        }
    }
    public int Rows
    {
        get
        {
            return ArrayMatrix.GetLength(0);
        }
        private set
        {
            Rows = value;
        }
    }
    public int Columns
    {
        get
        {
            return ArrayMatrix.GetLength(1);
        }
        private set
        {
            Columns = value;
        }
    }
    public Matrix()
    {
        ArrayMatrix = new int[,] { { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, } };
    }
    public Matrix(int[,] m)
    {
        this.ArrayMatrix = m;
    }
    public Matrix add(Matrix m2)
    {
        if (Rows == m2.Rows && Columns == m2.Columns)
        {
            int[,] tempMatrix = new int[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    tempMatrix[i, j] = ArrayMatrix[i, j] + m2.ArrayMatrix[i, j];
                }
            }
            return new Matrix(tempMatrix);
        }
        else
        {
            throw new Exception();
        }
    }
    public Matrix add(int[,] m2)
    {
        return this.add(new Matrix(m2));
    }
    public Matrix sub(Matrix m2)
    {
        if (Rows == m2.Rows && Columns == m2.Columns)
        {
            int[,] tempMatrix = new int[Rows, Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    tempMatrix[i, j] = ArrayMatrix[i, j] - m2.ArrayMatrix[i, j];
                }
            }
            return new Matrix(tempMatrix);
        }
        else
        {
            throw new Exception();
        }
    }
    public Matrix sub(int[,] m2)
    {
        return this.sub(new Matrix(m2));
    }
    public Matrix prod(Matrix m2)
    {
        if (Columns == m2.Rows)
        {
            int[,] tempMatrix = new int[Rows, m2.Columns];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < m2.Columns; j++)
                {
                    tempMatrix[i, j] = 0;
                    for (int k = 0; k < Columns; k++)
                    {
                        tempMatrix[i, j] += ArrayMatrix[i, k] * m2.ArrayMatrix[k, j];
                    }
                }
            }
            return new Matrix(tempMatrix);
        }
        else
        {
            throw new Exception();
        }
    }
    public Matrix prod(int[,] m2)
    {
        return prod(new Matrix(m2));
    }
    public Matrix transpose()
    { 
        int[,] resMatrix = new int[Columns, Rows];
        for (int i = 0; i < Columns; i++)
        {
            for (int j = 0; j < Rows; j++)
            {
                resMatrix[i, j] = ArrayMatrix[j, i];
            }
        }
        return new Matrix(resMatrix);
    }
}
