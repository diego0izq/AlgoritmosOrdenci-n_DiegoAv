using System;
using System.Diagnostics;
using System.Linq;


namespace ProyectoOrdenConsola
{
    public static class OrdenamientoShell
    {
        public static void Ordenar(int[] arreglo)
        {
            int n = arreglo.Length;
            for (int gap = n / 2; gap > 0; gap /= 2)
                for (int i = gap; i < n; i++)
                {
                    int temp = arreglo[i], j = i;
                    while (j >= gap && arreglo[j - gap] > temp)
                        arreglo[j] = arreglo[j - gap];
                    arreglo[j] = temp;
                }
        }
    }
}
