/*  
 *  Crear un programa que pida al usuario
 *  dos números enteros cortos y diga si
 *  son iguales o, en caso contrario, cuál
 *  es el mayor de ellos.
 *
 */
 
Console.WriteLine("\n\n Ejercicio #2: Comparación de 'A' y 'B' ");

Console.WriteLine("\n> \t ¿Serias tan Amable de Darme un Numero?");
int Num_A = int.Parse(Console.ReadLine());
Console.WriteLine("> \t Dame Otro Numero, porfavor");
int Num_B = int.Parse(Console.ReadLine());

if( Num_A == Num_B)
  Console.WriteLine("\n"+ Num_A +" Es el Mismo que "+ Num_B +"\n\n");
else
    if( Num_A > Num_B)
      Console.WriteLine("\n"+ Num_A +" Es Mayor que "+ Num_B +"\n\n");
    else
      Console.WriteLine("\n"+ Num_A +" Es Menor que "+ Num_B +"\n\n");