Console.WriteLine("\n\n ¡Ejercicio#1: Suma de Primos!");

int Suma_Valor_Primos = 0;

for(int i = 2; i <= 50; i++){
    int Cantidad_Divisiones_Exactas = 1;
    for(int j = 2; j <= 50; j++){
        if(i % j == 0){
            Cantidad_Divisiones_Exactas++;
        }
    }
    if(Cantidad_Divisiones_Exactas == 2){
        Suma_Valor_Primos = i + Suma_Valor_Primos;
    }
}

Console.WriteLine("\n > El valor de la suma de los Numero Primos comprendidos entre el 1 y 50 es de: "+Suma_Valor_Primos+"\n\n");