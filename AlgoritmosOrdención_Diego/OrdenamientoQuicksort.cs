using System;
using System.Diagnostics;
using System.Linq;

namespace ProyectoOrdenConsola
{
    public static class OrdenamientoQuicksort
    {
        public static void Ordenar(int[] arreglo, int bajo, int alto)
        {
            if (bajo < alto)
            {
                int pivote = Particionar(arreglo, bajo, alto);
                Ordenar(arreglo, bajo, pivote - 1);
                Ordenar(arreglo, pivote + 1, alto);
            }
        }

        private static int Particionar(int[] arreglo, int bajo, int alto)
        {
            int pivote = arreglo[alto], i = bajo;
            for (int j = bajo; j < alto; j++)
                if (arreglo[j] < pivote)
                    (arreglo[i], arreglo[j]) = (arreglo[j], arreglo[i++]);

            (arreglo[i], arreglo[alto]) = (arreglo[alto], arreglo[i]);
            return i;
        }
    }
}
