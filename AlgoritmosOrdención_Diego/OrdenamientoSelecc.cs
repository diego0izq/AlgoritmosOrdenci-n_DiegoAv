using System;
using System.Diagnostics;
using System.Linq;


namespace ProyectoOrdenConsola
{
    public static class OrdenamientoSeleccion
    {
        public static void Ordenar(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < arreglo.Length; j++)
                    if (arreglo[j] < arreglo[minIdx])
                        minIdx = j;
                (arreglo[i], arreglo[minIdx]) = (arreglo[minIdx], arreglo[i]);
            }
        }
    }
}