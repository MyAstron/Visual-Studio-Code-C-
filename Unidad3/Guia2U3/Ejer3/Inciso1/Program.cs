Console.WriteLine("\n\n ¡Ejercicio#3 Inciso 1: Dia de la Semana!");
string dia;
double valor;

Console.WriteLine("\n > Ingresa el Dia: ");
dia = Console.ReadLine();
valor = double.Parse(dia);


switch (valor) {
      case 1:
        Console.WriteLine("-> Lunes \n\n");
    break;
      case 2:
        Console.WriteLine(" -> Martes \n\n");
    break;
      case 3:
        Console.WriteLine(" -> Miercoles \n\n");
    break;
      case 4:
        Console.WriteLine(" -> Jueves \n\n");
    break;
      case 5:
        Console.WriteLine(" -> Viernes \n\n");
    break;
      case 6:
        Console.WriteLine(" -> Sabado \n\n");
    break;
      case 7:
        Console.WriteLine(" -> Domingo \n\n");
    break;
      default:
        Console.WriteLine(" -> No es un dia de la semana \n\n");
    break;
}