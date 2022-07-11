Console.WriteLine("\n\n ¡Ejercicio#3 Inciso 2: Calificaciones!");
string dia;
double valor;

Console.WriteLine("\n > Ingresa el Dia: ");
dia = Console.ReadLine();
valor = double.Parse(dia);


if (valor < 60) {
    Console.WriteLine("Perdiste la Materia! \n\n");
} else {
    Console.WriteLine("¡Felicidades! Ganaste!! \n\n");
}