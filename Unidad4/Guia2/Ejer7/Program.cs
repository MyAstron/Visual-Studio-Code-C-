/*
 *  Partiendo del 300, en cuenta regresiva
 * hasta el 1, cuenta los numeros primos hay
 * y la suma de los pares.
 *
 */

Console.WriteLine("\n\n\n┌── Pagina 107 - Actividad 4 - Ejercicio 2");
Console.WriteLine("└ Ejercicio#7: Cuenta regresiva \n\n");

int suma = 0, divisores = 0, primos = 0;
for (int i = 300; i >= 1; i--) {
  divisores = 0;
  for (int j = 300; j >= 1; j--) {
    if (i % j == 0)
      divisores++;
  }
  if (divisores == 2)
    primos++;
  if (i % 2 == 0)
    suma = suma + i;
}
Console.Write("\n> \t « Hay "+primos+" Numeros Primos entre el 300 y 1 »\n");
Console.Write("\n> \t « Suma Total de los Numeros Pares entre el 300 y 1 »\n > \t "+suma+"\n\n\n");