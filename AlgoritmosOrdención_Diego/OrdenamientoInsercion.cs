using System;
using System.Diagnostics;
using System.Linq;

namespace ProyectoOrdenConsola
{
    public static class OrdenamientoInsercion
    {
        public static void Ordenar(int[] arreglo)
        {
            for (int i = 1; i < arreglo.Length; i++)
            {
                int clave = arreglo[i], j = i - 1;
                while (j >= 0 && arreglo[j] > clave)
                    arreglo[j + 1] = arreglo[j--];
                arreglo[j + 1] = clave;
            }
        }
    }
}
