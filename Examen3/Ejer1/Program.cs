/*  
 *  Crear un programa que pida al usuario
 *  dos números enteros y diga si el
 *  primero es múltiplo del segundo (pista:
 *  igual que antes, habrá que ver si el
 *  resto de la división es cero: a % b ==
 *  0).
 *
 */

Console.WriteLine("\n\n Ejercicio #1: Múltiplo según 'B'");

Console.WriteLine("\n> \t ¿Serias tan Amable de Darme un Numero?");
int Num_A = int.Parse(Console.ReadLine());
Console.WriteLine("> \t Dame Otro Numero, porfavor");
int Num_B = int.Parse(Console.ReadLine());

if( Num_A % Num_B == 0)
  Console.WriteLine("\n"+ Num_A +" Si es Múltiplo de "+ Num_B +"\n\n");
else
  Console.WriteLine("\n"+ Num_A +" No es Múltiplo de "+ Num_B +"\n\n");