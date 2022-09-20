 /*
  *     Leer las Edades de siete personas (numeros
  *  enteros), almacenaarlas en un arreglo y 
  *  determinar cuantas de esas personas son mayores
  *  de edad.
  *
  */

// // // // TITULO \\ \\ \\ \\
Console.WriteLine("\n\n\n┌── Pagina 112 - Actividad 2 - Ejercicio 1"); 
Console.WriteLine("└ Ejercicio#1: Edades con Arreglos \n\n");

int []edad = new int[7]; // Iniciamos el arreglo de 'edades'

for (int i = 0; i < edad.Length; i++) { // Primer Ciclo [Ciclo para Almacenar Datos]

    // // // // Solicitamos una Edad \\ \\ \\ \\
    Console.Write("> Escribe la "+(i+1)+"º edad: ");
    edad[i] = Convert.ToInt32(Console.ReadLine()); // Se almacena
}

Console.WriteLine("\n\t« Edades Adultas »"); // Sub-titulo

for (int j = 0; j < edad.Length; j++) { // Segundo Ciclo [Ciclo para Mostrar Datos]

    if(edad[j] >= 18) // Si la edad (segun el ciclo) es mayor a 18...       (Es mayor de edad)
        Console.Write(edad[j]+" "); // Mostrarlo
}
Console.Write("\n\n\n");