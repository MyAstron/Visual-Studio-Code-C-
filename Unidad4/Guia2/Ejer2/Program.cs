/*
 *  Crea un Programa necesario para generar
 * las siguientes ternas de numero. Compila
 * y prueba el programa con un compañero.
 */

Console.WriteLine("\n\n\n┌── Pagina 104 - Actividad 3 - Ejercicio 1");
Console.WriteLine("└ Ejercicio#2: Crear el Patron - Tres Ciclos \n\n");

Console.WriteLine("\t ┌───┬───┬───┐");
Console.WriteLine("\t | x | y | z |");
Console.WriteLine("\t ├───┼───┼───┤");
for(int x = 1; x <= 2; x++){
  for(int y = 1; y <= 2; y++){
    for(int z = 1; z <= 3; z++){
      Console.Write("\t | "+x+" | "+y+" | "+z+" | \n");
    }
  }
}
Console.WriteLine("\t └───┴───┴───┘ \n\n\n");