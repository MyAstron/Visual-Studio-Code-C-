 /*
  *     Leer ocho enteros, almacenarlos en un arreglo
  *  y determinar en que posicion del arreglo esta el
  *  el mayor numero leido y mostrarlo.
  *
  */

// // // // TITULO \\ \\ \\ \\
Console.WriteLine("\n\n\n┌── Pagina 113 - Actividad 2 - Ejercicio 2"); 
Console.WriteLine("└ Ejercicio#3: Numero Mayor con Arreglos \n\n");

// // // // Iniciamos el arreglo y los acumuladores necesarios \\ \\ \\ \\
int []numeros = new int[8];
int numero_mayor = 0, posicion = 0;

for (int i = 0; i < numeros.Length; i++) { // Ciclo para Evaluar y Solicitar Datos (Edades)

    // // // // SOLICITAMOS DATOS \\ \\ \\ \\
    Console.Write("> Escribe un Numero...  ");
    numeros[i] = Convert.ToInt32(Console.ReadLine());

    // // // // Evaluamos \\ \\ \\ \\
    if (numeros[i] >= numero_mayor){ // Si hay un nuevo numero mayor
        // Acumulamos los datos ↓
        numero_mayor = numeros[i];
        posicion = i;
    }
}
// // // // Mostramos Datos Finales \\ \\ \\ \\
Console.WriteLine("\n\t« El Numero Mayor Ingresado es el "+numero_mayor+" en la posicion "+posicion+" » \n\n");