// // // // CONTEXTO \\ \\ \\ \\
/*
 *  En una feria, los boletos para subir a la rueda de la fortuna
 * cuestan $15 por adulto y $10 por niño. Hay un encargado que vende
 * los boletos y controla el acceso a la atraccion. El supervisor le
 * ha pedido que , en todo momento, lleve la cuenta del numero de 
 * boletos vendidos, asi como el total de dinero cobrado.
 */

// // // // PROGRAMA \\ \\ \\ \\
/*
 *  Crea un programa en C# que ayude
 * al encargado con el supervisor. 
 * El programa debe preguntar (por
 * cada repeticion):
 *      → Si la persona es Niño 
 *          « Presiona 1 »
 *        Si es Adulto
 *          « Presiona 2 »
 *      → Mostrar el numero de boletos
 *      vendidos y el total de cobro.
 * (Debes Utilizar un Ciclo).
 *
 */

Console.WriteLine("\n\n\n┌── Pagina 106 - Actividad 2 - Ejercicio 1");
Console.WriteLine("└ Ejercicio#3: En la Feria \n\n");

int ninos = 0, adultos = 0, monto = 0;
string siguiente = "Si";
do{
    Console.Write("\n> \t Si es Niño Ingresa 1, Si eres Adulto, Ingresa 2 » ");
    int edad = Convert.ToInt32(Console.ReadLine());
    if (edad.Equals(1)){
        monto = monto + 10;
            ninos++;
    }else if (edad.Equals(2)){
        monto = monto + 15;
            adultos++;
    }else{
        Console.WriteLine(" ¡solo puedes ingresar el (1) o (2)!".ToUpper());
    }

        Console.Write("¿Deseas Registrar Otro Boleto? » ");
        siguiente = Convert.ToString(Console.ReadLine());
}while(siguiente.StartsWith("S") || siguiente.StartsWith("s")); // Tipos de Codiciones ⮧
/*
 *  Otras formas de que se Cumpla la Condicion:
 *      → siguiente.Equals("Si")
 *      → !siguiente.Equals("No")
 *
 */
Console.WriteLine("\n\n \t ¡Datos Ingresados!\n » Monto Total: $."+monto+"\n « Boletos Vendidos »\nAdultos: "+adultos+" ($."+(adultos*15)+")\nNiños: "+ninos+" ($."+(ninos*10)+")\n\n\n");