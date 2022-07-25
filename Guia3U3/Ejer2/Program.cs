Console.WriteLine("\n\n ¡Ejercicio#2: Triangulo!");

Console.WriteLine("\n > Ingresa el valor del Primer Lateral (A): ");
int l1 = int.Parse(Console.ReadLine());
Console.WriteLine("> Ingresa el valor del Segundo Lateral (B): ");
int l2 = int.Parse(Console.ReadLine());
Console.WriteLine("> Ingresa el valor del Tercer Lateral (C): ");
int l3 = int.Parse(Console.ReadLine());

    if ((l1 == l2) && (l2 == l3))
        Console.WriteLine("\n Triangulo Equilatero \n\n");
    if ((l1 == l2) || (l1 == l3) || (l2 == l3))
        Console.WriteLine("\n Triangulo Isoceles \n\n");
    if ((l1 != l2) && (l2 != l3))
        Console.WriteLine("\n Triangulo Escaleno \n\n");