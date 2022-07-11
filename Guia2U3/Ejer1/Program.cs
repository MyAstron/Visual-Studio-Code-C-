Console.WriteLine("\n\n ¡Ejercicio#1: Edad!");
string edad;
double valor;

Console.WriteLine("\n > Ingresa tu Edad: ");
edad = Console.ReadLine();
valor = double.Parse(edad);


if (valor < 18) {
    Console.WriteLine("Aun eres menor de edad! \n\n");
}else{
    Console.WriteLine("Ya estas Viejito! \n\n");
}