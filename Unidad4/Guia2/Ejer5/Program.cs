/*
 *  El cajero del supermercado tiene varios
 * billetes de distintas denominaciones y
 * nesecita separar los de $.100, contar
 * cuantos son y la suma del valor total.
 * (Denominaciones: $.20, $.50 y $.100)
 *
 */

Console.WriteLine("\n\n\n┌── Pagina 106 - Actividad 3 - Ejercicio 2");
Console.WriteLine("└ Ejercicio#5: Contar y Acumular \n\n");

int num = 0, billetes = 0, monto = 0;
do {
  Console.Write("\n> \t ¿De que Denominacion es el Billete? » ");
  num = Convert.ToInt32(Console.ReadLine());
  if (num == 20 || num == 50){}
  else if(num == 100){
    billetes++;
    monto = monto + 100;
  }else 
    Console.WriteLine(" « solo se admiten billetes de $.20, $.50 y $.100 ($.0 para salir) »".ToUpper());
}while(num != 0);
Console.WriteLine("\n\n > Tienes "+billetes+" billetes de $.100, con un total de $."+monto+"\n\n\n");