/*
 *  Desarrolla el programa necesario para
 * mostrar la sumatoria de los primeros
 * 20 multiplos de 7 y mostrar cuantos de
 * esos son numeros pares.
 *
 */

// // // // TITULO \\ \\ \\ \\
Console.WriteLine("\n\n\n┌── Pagina 107 - Actividad 4 - Ejercicio 1");
Console.WriteLine("└ Ejercicio#6: Multiplos de 7 \n\n");

int suma = 0; // Iniciamos el acumulador 'suma'
Console.Write("\n> \t « Primeros 20 Numeros Multiplos Pares del 7 »\n\n"); // SUB-TITULO (decoracion)

for (int i = 1; i <= 20; i++) { // ↓ (Explicacion abajo)
  /*
   *    Traduccion: 
   *  Para cuando 'i', que es '1'. 
   *  Mientras sea Menor a '20'. 
   *  Se va Aumentando numero por numero
   */

  suma = suma + (i*7); // Acumulamos los multiplos de 7. Segun 'i'

  if ((i*7) % 2 == 0) // Si el multiplo es par
    Console.Write((i*7)+" "); // Mostrarlo
}

// // // // MOSTRAR DATOS \\ \\ \\ \\
Console.WriteLine("\n> La Suma Total de los Primos es de: "+suma+"\n\n\n");