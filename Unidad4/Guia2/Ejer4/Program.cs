/*
 *  Crea un programa en C# que muestre
 * en pantalla los numero primos entre
 * el 1 y el 100 y la suma total de los
 * mismo.
 *
 */

// // // // TITULO \\ \\ \\ \\
Console.WriteLine("\n\n\n┌── Pagina 106 - Actividad 3 - Ejercicio 1");
Console.WriteLine("└ Ejercicio#4: Contar y Acumular \n\n");

Console.Write("\n> \t « Numeros Primos Comprendidos Entre El 1 y 100 »\n\n"); // SUB-TITULO (decoracion)

int divisores = 0, suma = 0; // Declaramos e inciamos variables y acomuladores

for (int i = 1; i <= 100; i++) { // Ciclo 'i' ↓ (Explicacion abajo)
  /*
   *    Traduccion: 
   *  Para cuando 'i', que es '1'. 
   *  Mientras sea Menor a '100'. 
   *  Se va Reduciendo numero por numero
   */

  divisores = 0; // Reiniciamos los divisores
  for (int j = 1; j <= 100; j++){ // Ciclo 'j' ↓ (Explicacion abajo)
    /*
     *    Traduccion: 
     *  Para cuando 'j', que es '1'. 
     *  Mientras sea Menor a '100'. 
     *  Se va Aumentando numero por numero
     */

    if(i % j == 0) // Si el producto entre 'i' y 'j'
      divisores++; // Se acumulan la cantidad de los divisores
  } // Fin del Ciclo 'j'

  if (divisores == 2){ // Si solo tiene 2 divisores (1 y si mismo)
    Console.Write(i+" "); // Mostramos 'i'
    suma = suma + i; // Acumulamos la suma de los numeros 'i'
  }

} // Fin del Ciclo 'i'

// // // // MOSTRAMOS DATOS \\ \\ \\ \\
Console.WriteLine("\n> La Suma Total es de: "+suma+"\n\n\n");