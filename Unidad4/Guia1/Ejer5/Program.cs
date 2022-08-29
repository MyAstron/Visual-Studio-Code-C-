 /*
  *  Crea un programa que solicite dos
  * numeros enteros y mostrar la suma
  * comprendidos entre el numero menor
  * y el mayor.
  *
  */
Console.WriteLine("\n\n\n Ejercicio#3: Suma en Rango"); // Titulo

// Inciamos el Acumulador
int suma = 0;
        // Solicitud de los Numeros en Rango
Console.Write("\n\n> \t Ingresa un Numero Bajo: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("> \t Coloca otro Numero Mayor a "+x+": ");
int y = Convert.ToInt32(Console.ReadLine());

do {
    suma = suma + x;
    x++;
}while (x <= y);
Console.WriteLine("\n « La suma total de los numeros en el Rango es de: "+suma+" » \n\n\n");