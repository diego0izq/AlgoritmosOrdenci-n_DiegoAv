using System;
using System.Diagnostics;
using System.Linq;

namespace ProyectoOrdenConsola
{
    public static class OrdenamientoBurbuja
    {
        public static void Ordenar(int[] arreglo)
        {
            int n = arreglo.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arreglo[j] > arreglo[j + 1])
                        (arreglo[j], arreglo[j + 1]) = (arreglo[j + 1], arreglo[j]);
        }
    }
}