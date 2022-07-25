Console.WriteLine("\n\n ¡Ejercicio#3: Horario!");

Console.WriteLine("\n > Ingresa la hora: ");
double hora = double.Parse(Console.ReadLine());

if ((hora >= 7.00) && (hora <= 7.30))
    Console.WriteLine("El periodo es Lectura! \n\n");
if ((hora >= 7.31) && (hora <= 7.45))
    Console.WriteLine("El periodo es Buenos Dias! \n\n");
if ((hora >= 7.46) && (hora <= 9.25))
    Console.WriteLine("El periodo es Programacion! \n\n");
if ((hora >= 9.51) && (hora <= 10.40))
    Console.WriteLine("El periodo es Contabilidad! \n\n");
if ((hora >= 10.41) && (hora <= 11.20))
    Console.WriteLine("El periodo es Matematica! \n\n");
if ((hora >= 11.41) && (hora <= 12.30))
    Console.WriteLine("El periodo es Ingles! \n\n");
if (((hora >= 9.25) && (hora <= 9.50)) || ((hora >= 11.20) && (hora <= 11.40)))
    Console.WriteLine("¡Recreo! \n\n");