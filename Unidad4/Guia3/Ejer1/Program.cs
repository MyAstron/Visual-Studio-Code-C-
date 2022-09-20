 /*
  *     Usando VSC realice un programa que adivine
  *  el numero. Agrega un sistema de puntaje que
  *  muestre un mensaje, segun el numero de intentos
  *  en que se adivina el numero secreto. Al final
  *  de cada juego 
  *
  *  Cantidad de Intentos       Mensaje
  *   →     +15    : "Creo que no Entendiste el Juego"
  *   →  13  ~  14 : "Estas en el Promedio"
  *   →   9  ~  12 : "Excelente Tecnica"
  *   →   5  ~   8 : "¡Hoy es tu Dia de Suerte!"
  *   →   1  ~   4 : "¡Increible!"
  *
  */

// // // // Iniciamos Variables a Utilizar \\ \\ \\ \\
string Nuevo_Juego = "Si";
int Numero_Ingresado, Intentos;

do { // Primer Ciclo [Ciclo de Menu]

    // // // // ESTETICA \\ \\ \\ \\
    Console.Clear(); // Limpiamos Pantalla 
    Console.WriteLine("\n\n\n┌── Pagina 110 - Actividad 3 - Ejercicio #"); 
    Console.WriteLine("└ Ejercicio#1: El Juego de Adivinar \n\n");
    Console.WriteLine("\t« Epenzo un Nuevo Juego » \n");


    Random Objeto_Random = new Random(); // Obtenemos el objeto 'Random'
    int Numero_Adivinar = Objeto_Random.Next(1, 101); // Creamos un Variable 'Random' con parametros: 1, 101
    Intentos = 0; // Actualizamos los Intentos a '0'
    
    do{ // Segundo Ciclo [Ciclo del Juego]

        if (Intentos < 15){ // Si aun no pasa de los 15 intentos...

            // // // // Solicitamos un Numero \\ \\ \\ \\
            Console.Write("> Piensa. ¿Que Numero tengo en la Mente? ");
            Numero_Ingresado = Convert.ToInt32(Console.ReadLine());

            Intentos++; // Acumulamos los Intentos


            // // // // ESTETICA \\ \\ \\ \\
            if (Numero_Ingresado != Numero_Adivinar) // Si el Numero aun no lo adivina...
            Console.Write("\t ["+(15-Intentos)+" Intentos Restantes]\n"); // Mostrar los Intentos Faltantes
            else {} // En caso ya adivino el numero... No muestra nada


        } else { // En el Caso que ya uso los 15 intentos...
            Intentos = 15; // Actualizamos los intentos a '15'
            Numero_Ingresado = Numero_Adivinar; // Hacemos que "gane". (Esto es para que Termine el Ciclo del Juego)
            Console.WriteLine("\n\tEl Numero era: "+Numero_Adivinar+"\n"); // Mostramos el Numero que Tenia que Adivinar
        }
        
    } while (Numero_Adivinar!=Numero_Ingresado); // ↓ Checa abajo
     /*
      *     Condicional:
      *       (Traducida) → Si el Numero a Adivinar es Diferente al Numero Ingresado
      *     Y fin del Segundo Ciclo [Ciclo del Juego]
      *
      */ 

    // // // // AL FINALIZAR EL JUEGO \\ \\ \\ \\

    // // // // Verficamos los intentos que uso \\ \\ \\ \\
    if (Intentos >= 15)
        Console.Write("\n\n Creo que no Entendiste el Juego");
    else if ((Intentos >= 13) && (Intentos <= 14))
        Console.Write("\n\n Estas en el Promedio");
    else if ((Intentos >= 9) && (Intentos <= 12))
        Console.Write("\n\n Excelente Tecnica");
    else if ((Intentos >= 5) && (Intentos <= 8))
        Console.Write("\n\n ¡Hoy es tu Dia de Suerte!");
    else if ((Intentos >= 1) && (Intentos <= 4))
        Console.Write("\n\n ¡Increible!");
    else /* En el Caso de un 'Error' */
        Console.Write("\n\n Estoy Bugeao'...");
    // Todo esto Segun lo Solicito el Programa
    Console.Write(" \t ("+Intentos+" Intenos)");

    // // // // Preguntamos si quiere Seguir Jugando \\ \\ \\ \\
    Console.Write("\n\t¿Quieres Empezar un Nuevo Juego? [si] [no] > ");
    Nuevo_Juego = Convert.ToString(Console.ReadLine());

} while (Nuevo_Juego.StartsWith("S") || Nuevo_Juego.StartsWith("s")); // ↓ Traduccion Abajo
 /*
  *     → Si 'Nuevo_Juego' (Dato solicitado) comienza con 's' o con 'S'
  *         ('S' es la referencia a 'si')
  *
  *    Pueden Haber otras formas de que se cumpla esta condicion segun lo desee
  *
  */

// // // // ESTETICA \\ \\ \\ \\
Console.WriteLine("\n Gracias por ser mi Compañero <3 \n\n\n");