Console.WriteLine("\n\n ¡Ejercicio#3: Videojuego!");

Random Objeto_Random = new Random();
int Numero_Para_Adivinar = Objeto_Random.Next(1, 15);
int Monedas = 0;
int Numer_Usuario = 0;

Console.WriteLine("\n Tienes "+Monedas+"¢, Adivina ¿En que Numero estoy Pensando? (1 - 15)");
while(Monedas != 350){
    Numer_Usuario = int.Parse(Console.ReadLine());
    if(Monedas >= 350){
        Console.WriteLine("¡Tienes Muchas Monedas!  ("+Monedas+"¢)");
        Monedas = 350;
    }else if(Numer_Usuario == Numero_Para_Adivinar){
        Monedas = Monedas + 350;
        Console.WriteLine("¡Adivinaste el Numero!  ("+Monedas+"¢)");
        Monedas = 350;
    }else{
        Monedas = Monedas + Objeto_Random.Next(1, 50);
        Console.WriteLine("("+Monedas+"¢) Advina el Numero...");
    }
}
Console.WriteLine("¡¡NIVEL 5 DESBLOQUEADO!! \n\n");