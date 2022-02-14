using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Matrix
{
    public int[,] matrix { get; private set; }
    public string strMatrix
    {
        get
        {
            string str = "";
            for(int i = 0;i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    str += matrix[i,j] + " ";
                }
                str += "\r\n";
            }
            return str;
        }
    }
    public int r
    {
        get
        {
            return matrix.GetLength(0);
        }
        private set
        {
            r = value;
        }
    }
    public int c
    {
        get
        {
            return matrix.GetLength(1);
        }
        private set
        {
            c = value;
        }
    }
    public Matrix()
    {
        matrix = new int[,] { { 0, 0, 0, }, { 0, 0, 0, }, { 0, 0, 0, } };
    }
    public Matrix(int[,] m)
    {
        this.matrix = m;
    }
    public void show(string rowSpace = " ", string colSpace = "\n")
    {
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(matrix[i, j].ToString() + rowSpace);
            }
            Console.Write(colSpace);
        }
    }
    public Matrix add(Matrix m2)
    {

        if (r == m2.r && c == m2.c)
        {
            int[,] tempMatrix = new int[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    tempMatrix[i, j] = matrix[i, j] + m2.matrix[i, j];
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
        if (r == m2.r && c == m2.c)
        {
            int[,] tempMatrix = new int[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    tempMatrix[i, j] = matrix[i, j] - m2.matrix[i, j];
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
        if (c == m2.r)
        {
            int[,] tempMatrix = new int[r, m2.c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < m2.c; j++)
                {
                    tempMatrix[i, j] = 0;
                    for (int k = 0; k < c; k++)
                    {
                        tempMatrix[i, j] += matrix[i, k] * m2.matrix[k, j];
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
        int[,] tempMatrix = matrix;
        for (int i = 0; i < r; i++)
        {
            for (int j = i; j < c; j++)
            {
                int temp = tempMatrix[i, j];
                tempMatrix[i, j] = tempMatrix[j, i];
                tempMatrix[j, i] = temp;
            }
        }
        return new Matrix(tempMatrix);
    }
}
