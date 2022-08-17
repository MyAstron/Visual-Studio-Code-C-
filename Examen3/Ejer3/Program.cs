/*  
 *  Un programa que solicite un número
 *  dado por el usuario, con el número
 *  ingresado por el usuario muestre en
 *  pantalla la cantidad en serie de los
 *  números Fibonacci, evalué si el ultimo
 *  número mostrado es par o impar
 *  (Utilice ciclo For)
 *
 */
Console.WriteLine("\n\n Ejercicio #3: Números Fibonacci");

Console.WriteLine("\n> \t ¿Me Puedes dar un Número?");
int num = int.Parse(Console.ReadLine());

int a = 0;
int b = 1;
int c;
for(int i = 1; i <= num; i++){
    c = a + b;
    a = b;
    b = c; 
}
    if ( a % 2 == 0)
      Console.WriteLine("\n\t El Número Fibonacci de "+ num +" es par ("+ a +") \n\n");
    else 
      Console.WriteLine("\n\t El Número Fibonacci de "+ num +" es impar ("+ a +") \n\n");
