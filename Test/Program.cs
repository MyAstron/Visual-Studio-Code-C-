 /*
  *  Crear un programa en C Sharp que
  * obtenga el promedio de tres notas
  * (Para aprobar requiere 70pts).
  * (Utilice ciclo For)
  *
  */
Console.WriteLine("\n\n Ejercicio#1: Prueba Corta, Guia#1");

Console.Write("\n\n> \t Ingresa un Numero: ");
int num = Convert.ToInt32(Console.ReadLine());
int digito = 0;
int suma = 0;

do {
  digito = num % 10;
  suma = suma + digito;
  num = num / 10;
} while(num != 0);
Console.WriteLine("Suma total es de: "+suma+"\n\n");