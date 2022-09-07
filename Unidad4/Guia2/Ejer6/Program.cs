/*
 *  Desarrolla el programa necesario para
 * mostrar la sumatoria de los primeros
 * 20 multiplos de 7 y mostrar cuantos de
 * esos son numeros pares.
 *
 */

Console.WriteLine("\n\n\n┌── Pagina 107 - Actividad 4 - Ejercicio 1");
Console.WriteLine("└ Ejercicio#6: Multiplos de 7 \n\n");

int suma = 0;
Console.Write("\n> \t « Primeros 20 Numeros Multiplos Pares del 7 »\n\n");
for (int i = 1; i <= 20; i++) {
  suma = suma + (i*7);
  if ((i*7) % 2 == 0)
    Console.Write((i*7)+" ");
}
Console.WriteLine("\n> La Suma Total de los Primos es de: "+suma+"\n\n\n");