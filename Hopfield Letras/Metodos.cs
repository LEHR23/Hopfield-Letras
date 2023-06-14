using System;
using System.Collections.Generic;
using System.Text;

namespace Hopfield_Letras
{
    class Metodos
    {
        public Metodos()
        {

        }

        public int[,] multiplicaciovector(int[] v)
        {
            int[,] matriz = new int[v.Length, v.Length];
            for (int i = 0; i < v.Length; i++)
            {
                for (int j = 0; j < v.Length; j++)
                {
                    matriz[i, j] = v[i] * v[j];
                }
            }
            return matriz;
        }

        public int[,] sumamatrices(int[,] m1, int[,] m2)
        {
            int[,] matriz = new int[m1.GetLength(1), m1.GetLength(1)];
            for (int i = 0; i < m1.GetLength(1); i++)
            {
                for (int j = 0; j < m1.GetLength(1); j++)
                {
                    matriz[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return matriz;
        }

        public int[,] matrizentrenamiento(int[,] m)
        {
            for (int i = 0; i < m.GetLength(1); i++)
            {
                m[i, i] = 0;
            }
            return m;
        }

        public int[] multiplicacionmv(int[] vector, int[,] matriz)
        {
            int[] vres = new int[vector.Length];
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector.Length; j++)
                {
                    vres[i] += vector[j] * matriz[j, i];
                }
            }
            return vres;
        }

        public int[] funcionactivacion(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > 0)
                {
                    vector[i] = 1;
                }
                else
                {
                    vector[i] = -1;
                }
            }
            return vector;
        }

        public bool iguales(int[] v1, int[] v2)
        {
            for (int i = 0; i < v1.Length; i++)
            {
                if (v1[i] != v2[i])
                {
                    return true;
                }
            }

            return false;
        }

        public double[] distancia(int[,] hist, double[] prob)
        {
            double[] coseno = new double[2];
            double cont = 0;
            double valorx = 0;
            double valory = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    valorx = valorx + prob[j] * prob[j];
                    valory = valory + hist[i, j] * hist[i, j];
                    cont = cont + prob[j] * hist[i, j];
                }
                coseno[i] = cont / Math.Sqrt(valorx * valory);
                Console.WriteLine(coseno[i]);
                cont = 0;
                valorx = 0;
                valory = 0;
            }
            return coseno;
        }
    }
}
