/*
 *  El cajero del supermercado tiene varios
 * billetes de distintas denominaciones y
 * nesecita separar los de $.100, contar
 * cuantos son y la suma del valor total.
 * (Denominaciones: $.20, $.50 y $.100)
 *
 */

// // // // TITULO \\ \\ \\ \\
Console.WriteLine("\n\n\n┌── Pagina 106 - Actividad 3 - Ejercicio 2");
Console.WriteLine("└ Ejercicio#5: Contar y Acumular \n\n");

int num = 0, billetes = 0, monto = 0; // Declaramos e inciamos variables y acomuladores
do { // Inicio del Ciclo

  // // // // SOLICITUD DE UN NUMERO \\ \\ \\ \\
  Console.Write("\n> \t ¿De que Denominacion es el Billete? » "); 
  num = Convert.ToInt32(Console.ReadLine());
  
  if (num == 20 || num == 50){} // Si el billete es de $20 o $50;

  else if(num == 100){ // Si es de $100
    billetes++; // Acumular la cantidad de billetes
    monto = monto + 100; // Acumular el monto de los billetes de $100

  }else // En el caso que el billete sea de $20, $50 o $100
    Console.WriteLine(" « solo se admiten billetes de $.20, $.50 y $.100 ($.0 para salir) »".ToUpper()); // ↓ (Explicacion Abajo)
      /*
        // // // // SUB-TITULO \\ \\ \\ \\
       *  '.ToUpper()' → 'En mayusculas'
       */

}while(num != 0); // Mientras 'num' (valor del billete) sea distinto a '0'

// // // // MOSTRAR DATOS \\ \\ \\ \\ 
Console.WriteLine("\n\n > Tienes "+billetes+" billetes de $.100, con un total de $."+monto+"\n\n\n");