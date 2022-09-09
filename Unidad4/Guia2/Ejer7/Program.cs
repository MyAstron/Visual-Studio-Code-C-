/*
 *  Partiendo del 300, en cuenta regresiva
 * hasta el 1, cuenta los numeros primos hay
 * y la suma de los pares.
 *
 */


// // // // TITULO \\ \\ \\ \\
Console.WriteLine("\n\n\n┌── Pagina 107 - Actividad 4 - Ejercicio 2");
Console.WriteLine("└ Ejercicio#7: Cuenta regresiva \n\n");

int suma = 0, divisores = 0, primos = 0; // Declaramos e inciamos variables y acomuladores
for (int i = 300; i >= 1; i--) { // Ciclo 'i' ↓ (Explicacion abajo)
  /*
   *    Traduccion: 
   *  Para cuando 'i', que es '300'. 
   *  Mientras sea Mayor a '1'. 
   *  Se va Reduciendo numero por numero
   */

  divisores = 0; // Reiniciamos los divisores
  for (int j = 300; j >= 1; j--) { // Ciclo 'j' ↓ (Explicacion abajo)
    /*
     *    Traduccion: 
     *  Para cuando 'j', que es '300'. 
     *  Mientras sea Mayor a '1'. 
     *  Se va Reduciendo numero por numero
     */

    if (i % j == 0) // Si el producto entre 'i' y 'j'
      divisores++; // Se acumulan la cantidad de los divisores
  } // Fin del Ciclo 'j'

  if (divisores == 2) // Si solo tiene 2 divisores (1 y si mismo)
    primos++; // Acumulamos la cantidad de primo

  if (i % 2 == 0) // Si el numero 'i' es par. (producto de 'i' y 2)
    suma = suma + i; // Acumulamos la suma de los numeros pares

} //  Fin del Ciclo 'i'

// // // // MOSTRAMOS DATOS \\ \\ \\ \\
Console.Write("\n> \t « Hay "+primos+" Numeros Primos entre el 300 y 1 »\n");
Console.Write("\n> \t « Suma Total de los Numeros Pares entre el 300 y 1 »\n > \t "+suma+"\n\n\n");