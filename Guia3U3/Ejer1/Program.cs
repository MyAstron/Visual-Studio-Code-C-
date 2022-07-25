Console.WriteLine("\n\n ¡Ejercicio#1: Notas!");

Console.WriteLine("\n > Ingresa tu nota Actual: ");
int nota = int.Parse(Console.ReadLine());

if((nota >= 0) && (nota <= 2))
    Console.WriteLine("Tu nota es Deficiente... \n\n");
if((nota >= 3) && (nota <= 4))
    Console.WriteLine("Tu nota es Regular.. \n\n");
if((nota >= 5) && (nota <= 6))
    Console.WriteLine("Tu nota es Bien. \n\n");
if((nota >= 7) && (nota <= 8))
    Console.WriteLine("Tu nota es Muy Bien! \n\n");
if((nota >= 9) && (nota <= 10))
    Console.WriteLine("Tu nota es Excelente! \n\n");