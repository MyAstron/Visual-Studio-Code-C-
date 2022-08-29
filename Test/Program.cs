 /*
  *  Crear un programa en C Sharp que
  * obtenga el promedio de tres notas
  * (Para aprobar requiere 70pts).
  * (Utilice ciclo For)
  *
  */
Console.WriteLine("\n\n Ejercicio#2: Promedio de Notas");

int Promedio = 0;
int Suma = 0;
for (int i = 1; i <= 3; i++) {
  int nota = 0;
  Console.WriteLine("\n> Coloca la "+i+"º nota: ");
  nota = int.Parse(Console.ReadLine());
  Suma = Suma + nota;
}
Promedio = Suma / 3;

if (Promedio >= 70)
  Console.WriteLine("\n ¡Aprobaste! Tu promedio es Mayor a 70 pts. ("+Promedio+") \n\n\n");
else
  Console.WriteLine("\n Reprobaste... Tu promedio es Menor a 70 pts. ("+Promedio+") \n\n\n");