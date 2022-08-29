 /*
  *  Crear un programa en C# para leer
  * un numero entero y calcular su 
  * factorial.
  *
  */
Console.WriteLine("\n\n\n Ejercicio#1: Factorial de un Numero"); // Titulo

// Iniciamos Variables
int i = 1;
int factorial = 1;

        // Solicitud del Numero a Evaluar
Console.Write("\n\n> \t Ingresa un Numero: ");
int num = Convert.ToInt32(Console.ReadLine());

do {
    factorial = factorial * i;
    i++;
}while (i <= num);
Console.WriteLine("\n « El Factorial de "+num+" es: "+factorial+" » \n\n\n");