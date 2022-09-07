/*
 *  Crea un Programa para generar el siguiente
 * par de numeros. Debes crear un programa
 * independiente para cada reto.
 * (Se recomienda usar ciclo For).
 */

Console.WriteLine("\n\n\n┌── Pagina 104 - Actividad 2 - Ejercicio 1");
Console.WriteLine("└ Ejercicio#1: Crear Patrones \n\n");

// // //   ESTOS PROGRAMAS DEBEN IR POR APARTE   \\ \\ \\
// Programa #1
Console.WriteLine("\t ┌───┬───┐");
Console.WriteLine("\t | x | y |");
Console.WriteLine("\t ├───┼───┤");
for(int i = 2; i <= 5; i++){
  for(int j = 0; j <= 1; j++){
    Console.Write("\t | "+i+" | "+j+" |\n");
  }
}
Console.WriteLine("\t └───┴───┘ \n\n\n");
// Fin del Programa #1

// // // // // // // // // // \\ \\ \\ \\ \\ \\ \\ \\ \\ \\

// Programa #2
int y = 1;
Console.WriteLine("\t ┌───┬───┐");
Console.WriteLine("\t | x | y |");
Console.WriteLine("\t ├───┼───┤");
for(int x = 4; x <= 6; x++){
  for(int i = 1; i <= 3; i++){
    Console.Write("\t | "+x+" | "+y+" |\n");
    y++;
  }
}
Console.WriteLine("\t └───┴───┘ \n\n\n");
// Fin del Programa #2