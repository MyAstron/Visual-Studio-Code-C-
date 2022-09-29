 /*
  *     El sistema del juego se basara
  *  en sumar dos numeros aleatorios de
  *  los dados previamente lanzados y
  *  utilizar un metodo para apuestas.
  *
  */

Random Objeto_Random = new Random();
int Seguir_Jugando = 0, Renovar_Bts = 0; // '0' va a ser 'si' y '1' es 'no'
int Dado_1, Dado_2, Monto_Usuario = 500, Apuesta_Usuario, Apuesta_CPU = 0;
int Dado_CPU_1, Dado_CPU_2, Suma_CPU, Rachas = 0;
String Comprar = "A";

do {
    Console.Clear();
    if (Rachas >= 3)
        Console.WriteLine("\n\n> \t ¡Racha de "+Rachas+" Victorias!");
    else
        Console.WriteLine("\n\n> \t Juegos de los Dados con Apuestas...");
    Dado_1 = Objeto_Random.Next(1, 7);
    Dado_2 = Objeto_Random.Next(1, 7);
    Dado_CPU_1 = Objeto_Random.Next(1, 7);
    Dado_CPU_2 = Objeto_Random.Next(1, 7);
    Suma_CPU = Dado_CPU_1 + Dado_CPU_2;
    if ((Suma_CPU >= 0) && (Suma_CPU <= 3)) {
        Apuesta_CPU = Objeto_Random.Next(0, 125);
    } else
    if ((Suma_CPU >= 4) && (Suma_CPU <= 6)) {
        Apuesta_CPU = Objeto_Random.Next(125, 250);
    } else
    if ((Suma_CPU >= 7) && (Suma_CPU <= 9)) {
        Apuesta_CPU = Objeto_Random.Next(250, 375);
    } else
    if ((Suma_CPU >= 10) && (Suma_CPU <= 12)) {
        Apuesta_CPU = Objeto_Random.Next(375, 500);
    }
    Console.Write("\n\n La suma de tus dados es de: "+(Dado_1+Dado_2)+"\n(1° Dado: "+Dado_1+", 2° Dado: "+Dado_2+")\n\n\t[  0 = No Apostar ] [ 1 = Apostar Todo ]\n");
    Console.Write("\n> ¡Coloca tu Apuesta! > β.");
    Apuesta_Usuario = Convert.ToInt32(Console.ReadLine());
    Thread.Sleep(1000);
    if (Apuesta_Usuario == 0)
        Apuesta_Usuario = 0;
    if (Apuesta_Usuario == 1)
        Apuesta_Usuario = Monto_Usuario;
    if (Apuesta_Usuario > Monto_Usuario) {
        Console.WriteLine(" TU SOLO TIENES β."+Monto_Usuario);
        Console.Write("\n> ¡Coloca tu Apuesta! > β.");
        Apuesta_Usuario = Convert.ToInt32(Console.ReadLine());
    }
    Monto_Usuario = Monto_Usuario - Apuesta_Usuario;

        if (Apuesta_Usuario == 0) {
            Console.WriteLine("> ¡Haz Abandonado la Partida!");
            Rachas = 0;
        } else
        if (Apuesta_CPU == 0) {
            Console.WriteLine("> ¡El CPU Abandono la Partida!");
            Monto_Usuario = Monto_Usuario + Apuesta_Usuario;
            Rachas++;
        } else
        if ((Dado_1+Dado_2) > (Dado_CPU_1+Dado_CPU_2)) {
            Console.WriteLine("> ¡Haz Ganado!");
            if (Dado_1 == Dado_2){
                Monto_Usuario = Monto_Usuario + (Apuesta_Usuario + Apuesta_CPU);
                Monto_Usuario = Monto_Usuario * 2;
            } else {
                Monto_Usuario = Monto_Usuario + (Apuesta_Usuario + Apuesta_CPU);
            }
            Rachas++;
        } else
        if ((Dado_1+Dado_2) < (Dado_CPU_1+Dado_CPU_2)) {
            Console.WriteLine("> Suerte a la Proxima...");
            Rachas = 0;
        } else
        if ((Dado_1+Dado_2) == (Dado_CPU_1+Dado_CPU_2)) {
            Console.WriteLine("> ¡EMPATE!");
            Thread.Sleep(1000);
            if(((Dado_1 > Dado_CPU_1) && (Dado_1 > Dado_CPU_2)) || ((Dado_2 > Dado_CPU_1) && (Dado_2 > Dado_CPU_2))){
                Console.WriteLine("> ¡Terminaste Ganando!");
                Console.WriteLine(" Uno de tus Dados es Mayor que los dados del CPU");
                Monto_Usuario = Monto_Usuario + (Apuesta_Usuario + Apuesta_CPU);
                Rachas++;
            } else
            if(((Dado_CPU_1 < Dado_1) && (Dado_CPU_1 < Dado_2)) || ((Dado_CPU_2 < Dado_1) && (Dado_CPU_2 < Dado_2))){
                Console.WriteLine("> ¡Caray! No has tenido mucha suerte...");
                Console.WriteLine(" El CPU te Gano por un dado...");
                Rachas = 0;
            } else {
                Console.WriteLine("> ¡¿What, Doble Empate?!");
                Console.WriteLine(" ¡Se Devuelven las Apuestas!");
                Monto_Usuario = Monto_Usuario + Apuesta_Usuario;
            }
        }
        Thread.Sleep(1000);
        Console.WriteLine("\n\n> \t Tu Puntaje es: "+(Dado_1+Dado_2));
        Console.WriteLine("> \t El Puntaje del CPU es: "+(Dado_CPU_1+Dado_CPU_2));
        Console.WriteLine(" \t ,-------------------------,");
        Console.WriteLine(" \t | Tus Dados | Los del CPU |");
        Console.WriteLine(" \t |-------------------------|");
        Console.WriteLine(" \t | 1°:   "+Dado_1+"   |  1°:   "+Dado_CPU_1+"    |");
        Console.WriteLine(" \t | 2°:   "+Dado_2+"   |  2°:   "+Dado_CPU_2+"    |");
        Console.WriteLine(" \t '-------------------------'");
        if ((Dado_1 == Dado_2) && (Rachas >= 1)) Console.WriteLine("> \t Twins: ¡GANASTE PUNTOS DOBLES!");
        Console.WriteLine("\n\n");
        Console.WriteLine("Tu Apuesta:\t\tβ."+Apuesta_Usuario);
        Console.WriteLine("Apuesta del CPU:\tβ."+Apuesta_CPU);
        Console.WriteLine("\n« Ahora tienes β."+Monto_Usuario+" »");

        Thread.Sleep(1000);
        Console.Write("\n\n\t « Menu »\n  [0] Si \t [1] No");
        if (Monto_Usuario > 0){
            Console.Write("\n ¿Quieres Jugar de Nuevo? > ");
            Seguir_Jugando = Convert.ToInt32(Console.ReadLine());
            if (Seguir_Jugando == 1)
                Console.WriteLine("\n\n> \t Gracias por Jugar <3 \n\n\n");
        }else{
            Console.Write("\n\n ¡Se te Acabaron los BTS! \n");
            Console.Write("¿Quieres Renovar los BTS? > ");
            Renovar_Bts = Convert.ToInt32(Console.ReadLine());
            if (Renovar_Bts == 0) {
                Console.WriteLine(" \t ,------------------------------,");
                Console.WriteLine(" \t | Opcion | Valor Q. | Valor β. |");
                Console.WriteLine(" \t |------------------------------|");
                Console.WriteLine(" \t |   (A)  | Q.10,000 | β.10,000 |");
                Console.WriteLine(" \t |   (B)  | Q. 1,000 | β. 1,000 |");
                Console.WriteLine(" \t '------------------------------'");
                Console.Write("\n\n> \t ¿Cual deseas Comprar? > ");
                Comprar = Convert.ToString(Console.ReadLine());
                if (Comprar.Equals("A") || Comprar.Equals("a")) {
                    Monto_Usuario = 10000;
                    Seguir_Jugando = 0;
                } else 
                if (Comprar.Equals("B") || Comprar.Equals("b")){
                    Monto_Usuario = 1000;
                    Seguir_Jugando = 0;
                } else {
                    Console.WriteLine("\n\n \t Ocurrio un Error!");
                    Seguir_Jugando = 1;
                }
            } else {
                Seguir_Jugando = 1;
                Console.WriteLine("\n\n\n> \t Gracias por Jugar <3 \n\n");
            }
        }
} while (Seguir_Jugando == 0);