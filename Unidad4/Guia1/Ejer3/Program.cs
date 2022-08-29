 /*
  *  Haz un nuevo programa para leer
  * dos numeros enteros y mostrar los
  * multiplos de 4 comprendidos entre
  * el numero menor y el mayor.
  *
  */
Console.WriteLine("\n\n\n Ejercicio#2: Multiplos de 4 en Rango"); // Titulo

        // Solicitud de los Numeros en Rango
Console.Write("\n\n> \t Ingresa un Numero Bajo: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("> \t Coloca otro Numero Mayor a "+x+": ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n « Multiplos de \"4\" entre "+x+" y "+y+" » \n");
do {
    if(x % 4 == 0)
      Console.Write(x+" ");
    x++;
}while (x <= y);
Console.Write("\n\n\n\n");