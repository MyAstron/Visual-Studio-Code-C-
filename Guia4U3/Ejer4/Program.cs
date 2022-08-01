Console.WriteLine("\n\n ¡Ejercicio#4: Multiplos de × Numero!");

Console.WriteLine("\n > Ingresa un Numero: ");
int num = int.Parse(Console.ReadLine());

int i = 1;
while(i <= 10){
    Console.WriteLine(num+" × "+i+" = "+(num*i));
    i++;
}