using System;
using System.Diagnostics;
using System.Linq;


namespace ProyectoOrdenConsola
{
    public static class OrdenamientoHeapsort
    {
        public static void Ordenar(int[] arreglo)
        {
            int n = arreglo.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(arreglo, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                (arreglo[0], arreglo[i]) = (arreglo[i], arreglo[0]);
                Heapify(arreglo, i, 0);
            }
        }

        private static void Heapify(int[] arreglo, int n, int i)
        {
            int mayor = i, izq = 2 * i + 1, der = 2 * i + 2;
            if (izq < n && arreglo[izq] > arreglo[mayor]) mayor = izq;
            if (der < n && arreglo[der] > arreglo[mayor]) mayor = der;
            if (mayor != i)
            {
                (arreglo[i], arreglo[mayor]) = (arreglo[mayor], arreglo[i]);
                Heapify(arreglo, n, mayor);
            }
        }
    }
}
