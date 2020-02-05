using System;

namespace Lab4
{
    class Matrix
    {
        static Random rnd = new Random();
        private double[,] a;
        public Matrix(int line = 3, int cologne = 3)
        {
            a = new double[line, cologne];
            for (int x = 0; x < line; x++)
            {
                for (int y = 0; y < cologne; y++)
                {
                    a[x, y] = rnd.Next(0, 10);
                }
            }
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.a.GetLength(0) != b.a.GetLength(0) || a.a.GetLength(1) != b.a.GetLength(1))
            {
                return null;
            }
            else
            {
                Matrix res = new Matrix(a.a.GetLength(0), a.a.GetLength(1));
                for (int x = 0; x < a.a.GetLength(0); x++)
                {
                    for (int y = 0; y < a.a.GetLength(1); y++)
                    {
                        res.a[x, y] = a.a[x, y] + b.a[x, y];
                    }
                }
                return res;
            }
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.a.GetLength(0) != b.a.GetLength(0) || a.a.GetLength(1) != b.a.GetLength(1))
            {
                return null;
            }
            else
            {
                Matrix res = new Matrix(a.a.GetLength(0), a.a.GetLength(1));
                for (int x = 0; x < a.a.GetLength(0); x++)
                {
                    for (int y = 0; y < a.a.GetLength(1); y++)
                    {
                        res.a[x, y] = a.a[x, y] - b.a[x, y];
                    }
                }
                return res;
            }
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.a.GetLength(1) != b.a.GetLength(0) || a.a.GetLength(0) != b.a.GetLength(1))
            {
                return null;
            }
            else
            {
                Matrix res = new Matrix(a.a.GetLength(0), b.a.GetLength(1));
                for (int x = 0; x < a.a.GetLength(0); x++)
                {
                    for (int y = 0; y < b.a.GetLength(1); y++)
                    {
                        for (int k = 0; k < b.a.GetLength(0); k++)
                        {
                            res.a[x, y] += a.a[x, k] * b.a[k, y];
                        }
                    }
                }
                return res;
            }
        }
        public static Matrix operator *(Matrix a, int b)
        {
            if (b == 0) return null;
            else
            {
                Matrix res = new Matrix(a.a.GetLength(0), a.a.GetLength(1));
                for (int x = 0; x < a.a.GetLength(0); x++)
                {
                    for (int y = 0; y < a.a.GetLength(1); y++)
                    {
                        res.a[x, y] = a.a[x, y] * b;
                    }
                }
                return res;
            }
        }
        public static Matrix operator ~(Matrix a)
        {
            Matrix result = new Matrix(a.a.GetLength(1), a.a.GetLength(0));
            for (int y = 0; y < a.a.GetLength(0); y++)
            {
                for (int x = 0; x < a.a.GetLength(1); x++)
                {
                    result.a[x, y] = a.a[y, x];
                }
            }
            return result;
        }
        public override string ToString()
        {
            string str = "";
            for (int x = 0; x < a.GetLength(0); x++)
            {
                for (int y = 0; y < a.GetLength(1); y++)
                {
                    str += $"{a[x, y],-5}";
                }
                str += "\n";
            }
            return str;
        }

    }
}
