 /*
  *  Muestre los numeros impares 
  * comprendidos entre 1 y el numero
  * ingresado por el usuario.
  *
  */
Console.WriteLine("\n\n\n Ejercicio#4: Impares entre 1 y \"x\""); // Titulo

// Iniciamos el Acumulador (1)
int x = 1;
        // Solicitud del otro Rango
Console.Write("\n\n> \t Coloca un Numero Positivo: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n « Impares entre 1 y "+y+" » \n");
do {
    Console.Write(x+" ");
    x = x + 2;
}while (x <= y);
Console.Write("\n\n\n\n");