/*
 *  Crea un Programa para generar el siguiente
 * par de numeros. Debes crear un programa
 * independiente para cada reto.
 * (Se recomienda usar ciclo For).
 */

// // // // TITULO \\ \\ \\ \\
Console.WriteLine("\n\n\n┌── Pagina 104 - Actividad 2 - Ejercicio 1");
Console.WriteLine("└ Ejercicio#1: Crear Patrones \n\n");


// // //   ESTOS PROGRAMAS DEBEN IR POR APARTE   \\ \\ \\
// Programa #1
// // // // DECORACION \\ \\ \\ \\
Console.WriteLine("\t ┌───┬───┐");
Console.WriteLine("\t | x | y |");
Console.WriteLine("\t ├───┼───┤");

for(int i = 2; i <= 5; i++){ // ↓ (Explicacion abajo)
  /*
   *    Traduccion: 
   *  Para cuando 'i', que es '2'. 
   *  Mientras sea Menor a '5'. 
   *  Se va Aumentando numero por numero
   */
  for(int j = 0; j <= 1; j++){ // ↓ (Explicacion abajo)
    /*
     *    Traduccion: 
     *  Para cuando 'j', que es '0'. 
     *  Mientras sea Menor a '1'. 
     *  Se va Aumentando numero por numero
     */

    // // // // MOSTRAMOS DATOS \\ \\ \\ \\
    Console.Write("\t | "+i+" | "+j+" |\n");
  } // Fin del Ciclo 'j'
} // Fin del Ciclo 'i'
// // // // FIN DE LA TABLA (DECORACION) \\ \\ \\ \\
Console.WriteLine("\t └───┴───┘ \n\n\n");
// Fin del Programa #1


// // // // // // // // // // \\ \\ \\ \\ \\ \\ \\ \\ \\ \\


// Programa #2
int y = 1; // Iniciamos el acumulador 'y'

// // // // DECORACION \\ \\ \\ \\
Console.WriteLine("\t ┌───┬───┐");
Console.WriteLine("\t | x | y |");
Console.WriteLine("\t ├───┼───┤");

for(int x = 4; x <= 6; x++){ // ↓ (Explicacion abajo)
  /*
   *    Traduccion: 
   *  Para cuando 'x', que es '4'. 
   *  Mientras sea Menor a '6'. 
   *  Se va Aumentando numero por numero
   */
  for(int i = 1; i <= 3; i++){ // ↓ (Explicacion abajo)
    /*
     *    Traduccion: 
     *  Para cuando 'i', que es '1'. 
     *  Mientras sea Menor a '3'. 
     *  Se va Aumentando numero por numero
     */

    // // // // MOSTRAMOS DATOS \\ \\ \\ \\
    Console.Write("\t | "+x+" | "+y+" |\n");
    y++; // Acumular Y
  }
}
Console.WriteLine("\t └───┴───┘ \n\n\n");
// Fin del Programa #2