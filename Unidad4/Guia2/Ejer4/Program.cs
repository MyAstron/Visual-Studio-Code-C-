/*
 *  Crea un programa en C# que muestre
 * en pantalla los numero primos entre
 * el 1 y el 100 y la suma total de los
 * mismo.
 *
 */

Console.WriteLine("\n\n\n┌── Pagina 106 - Actividad 3 - Ejercicio 1");
Console.WriteLine("└ Ejercicio#4: Contar y Acumular \n\n");

Console.Write("\n> \t « Numeros Primos Comprendidos Entre El 1 y 100 »\n\n");
int divisores = 0, suma = 0;
for (int i = 1; i <= 100; i++) {
  divisores = 0;
  for (int j = 1; j <= 100; j++){
    if(i % j == 0)
        divisores++;
  }
  if (divisores == 2){
    Console.Write(i+" ");
    suma = suma + i;
  }
}
Console.WriteLine("\n> La Suma Total es de: "+suma+"\n\n\n");