Console.WriteLine("\n\n ¡Ejercicio#2: 20 Multiplos de (×)!");

Console.WriteLine("\n > Ingresa un Numero: ");
int num = int.Parse(Console.ReadLine());

for(int i = 1; i <= 20; i++){
    Console.WriteLine(num+" × "+i+" = "+(num*i));
}