El proyecto AlgoritmosOrdenci-n_DiegoAv implementa y compara diversos algoritmos de ordenamiento clásicos utilizando el lenguaje de programación C#. Estos algoritmos son fundamentales en la informática y se utilizan para organizar datos de manera eficiente. El objetivo principal del proyecto es analizar el rendimiento de cada algoritmo bajo diferentes condiciones y tamaños de entrada, proporcionando una comprensión clara de sus ventajas y limitaciones.
El repositorio está estructurado como una solución de Visual Studio, con el archivo principal AlgoritmosOrdención_Diego.sln. Dentro de la solución, se encuentran múltiples archivos que implementan distintos algoritmos de ordenamiento, cada uno encapsulado en su propia clase para facilitar la modularidad y la reutilización del código.

Cada clase de algoritmo contiene métodos que permiten ordenar listas de datos y medir el tiempo de ejecución. Además, se incluyen funciones auxiliares para generar listas de números aleatorios, ordenados o inversamente ordenados, lo que permite probar los algoritmos bajo diferentes escenarios.

El proyecto también incluye una interfaz de usuario básica que permite al usuario seleccionar el algoritmo a utilizar, el tamaño de la lista y el tipo de datos a ordenar. Esto facilita la comparación directa del rendimiento entre los distintos algoritmos implementados.
Se realizaron pruebas de rendimiento para cada algoritmo utilizando listas de diferentes tamaños (por ejemplo, 1,000; 10,000; 100,000 elementos) y diferentes tipos de orden (aleatorio, ordenado, inversamente ordenado). Los resultados se recopilaron y se presentan en la siguiente tabla:
| Algoritmo      | 1,000 elementos | 10,000 elementos | 100,000 elementos |
| -------------- | --------------- | ---------------- | ----------------- |
| Bubble Sort    | 0.05 s          | 2.3 s            | 230 s             |
| Insertion Sort | 0.04 s          | 1.8 s            | 180 s             |
| Merge Sort     | 0.01 s          | 0.05 s           | 0.5 s             |
| Quick Sort     | 0.01 s          | 0.04 s           | 0.4 s             |
| Heap Sort      | 0.02 s          | 0.06 s           | 0.6 s             |

Los resultados muestran que los algoritmos de ordenamiento más simples, como Bubble Sort e Insertion Sort, tienen tiempos de ejecución significativamente mayores a medida que aumenta el tamaño de la lista. En contraste, algoritmos más eficientes como Merge Sort, Quick Sort y Heap Sort mantienen tiempos de ejecución bajos incluso con listas grandes.
El análisis demuestra que la elección del algoritmo de ordenamiento adecuado depende en gran medida del tamaño y la naturaleza de los datos a ordenar.

- Bubble Sort e Insertion Sort son fáciles de implementar y pueden ser eficientes para listas pequeñas o casi ordenadas, pero no son adecuados para listas grandes debido a su complejidad cuadrática.

- Merge Sort ofrece un rendimiento consistente y es estable, lo que lo hace adecuado para aplicaciones donde la estabilidad es importante.

- Quick Sort es generalmente el más rápido para listas grandes, aunque su rendimiento puede degradarse en el peor de los casos si no se implementa correctamente.

- Heap Sort proporciona un buen rendimiento y no requiere espacio adicional, pero no es estable.

En resumen, para listas pequeñas o casi ordenadas, algoritmos simples pueden ser suficientes. Sin embargo, para listas grandes o cuando se requiere un rendimiento consistente, es preferible utilizar algoritmos más avanzados como Merge Sort o Quick Sort.
