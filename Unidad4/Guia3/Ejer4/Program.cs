 /*
  *     Desarrolla un algoritmo de un programa
  *  para leer 15 numeros enteros, almacenarlos
  *  y determinar si existe al menos un numero
  *  repetido.
  *
  */

// // // // TITULO \\ \\ \\ \\
Console.WriteLine("\n\n\n┌── Pagina 113 - Actividad 3 - Ejercicio 1"); 
Console.WriteLine("└ Ejercicio#4: Numeros Repetidos con Arreglos \n\n");

// // // // Iniciamos el Arreglo y los acumuladores \\ \\ \\ \\
int []numeros = new int[15];
int repeticiones, evaluacion;

for (int i = 0; i < numeros.Length; i++) { // Primer Ciclo [Ciclo para Solicitar Datos]
    Console.Write("> Ingresa un numero...  ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("\n\t « Numeros que se Repiten mas de Una Vez »"); // Sub-titulo [Estetica]

// // // // GENERAMOS UN PLANO CARTESIANO \\ \\ \\ \\
for (int x = 0; x < numeros.Length; x++) { // Segundo Ciclo [Primer Ciclo para Evaluar 'x']
    repeticiones = 0; // Actualizamos las repeticiones en '0' de 'x'
    
    for (int y = 0; y < numeros.Length; y++) { // Tercer ciclo [Segundo Ciclo para Evaluar en 'y']

        if (numeros[x] == numeros[y]) // Si el numero en 'x' y en 'y' es el mismo...
            repeticiones++; // Acumulamos su Repeticion. (Significa que se repite una vez)

    } // Fin del Tercer Ciclo [Segundo Ciclo para Evaluar en 'y']
    
    // // // // SISTEMA GRAFICO PARA UNA MEJOR ESTETICA \\ \\ \\ \\
    evaluacion = 0; // Actualizamos las evaluaciones en '0'

    for (int j = 0; j <= x; j++) { // Cuarto Ciclo [Ciclo para Contar las Veces que se Repite 'x']

        if (numeros[j] == numeros[x]) // Si 'x' se repite...
            evaluacion++; // Acumulamos la evaluacion. (Para saber la cantidad de veces que se repite dentro del arreglo)

    } // Fin del Cuarto Ciclo [Ciclo para Contar las Veces que se Repite 'x']

    // // // // Evaluamos los numeros que se repitan mas de dos veces \\ \\ \\ \\
// (Tambien se agrego para que las 'evaluaciones' sean de '1' implica que solo se va a escribir una vez en la consola/terminal)
    if((repeticiones>= 2) && (evaluacion == 1)) 
        Console.WriteLine(" → Numero Evaluado: "+numeros[x]+", Veces Repetidas: "+repeticiones); // Mostramos Datos
}
Console.WriteLine("\n\n\n");