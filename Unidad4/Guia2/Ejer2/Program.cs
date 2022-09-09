/*
 *  Crea un Programa necesario para generar
 * las siguientes ternas de numero. Compila
 * y prueba el programa con un compañero.
 */

// // // // TITULO \\ \\ \\ \\
Console.WriteLine("\n\n\n┌── Pagina 104 - Actividad 3 - Ejercicio 1");
Console.WriteLine("└ Ejercicio#2: Crear el Patron - Tres Ciclos \n\n");

// // // // DECORACION \\ \\ \\ \\
Console.WriteLine("\t ┌───┬───┬───┐");
Console.WriteLine("\t | x | y | z |");
Console.WriteLine("\t ├───┼───┼───┤");

for(int x = 1; x <= 2; x++){ // ↓ (Explicacion abajo)
  /*
   *    Traduccion: 
   *  Para cuando 'x', que es '1'. 
   *  Mientras sea Menor a '2'. 
   *  Se va Aumentando numero por numero
   */
  for(int y = 1; y <= 2; y++){ // ↓ (Explicacion abajo)
    /*
     *    Traduccion: 
     *  Para cuando 'y', que es '1'. 
     *  Mientras sea Menor a '2'. 
     *  Se va Aumentando numero por numero
     */
    for(int z = 1; z <= 3; z++){ // ↓ (Explicacion abajo)
      /*
       *    Traduccion: 
       *  Para cuando 'z', que es '1'. 
       *  Mientras sea Menor a '3'. 
       *  Se va Aumentando numero por numero
       */
      
      // // // // MOSTRAMOS DATOS \\ \\ \\ \\
      Console.Write("\t | "+x+" | "+y+" | "+z+" | \n");
    } // Fin del Ciclo 'z'
  } // Fin del Ciclo 'y'
} // Fin del Ciclo 'x'

// // // // FIN DE LA TABLA (DECORACION) \\ \\ \\ \\
Console.WriteLine("\t └───┴───┴───┘ \n\n\n");