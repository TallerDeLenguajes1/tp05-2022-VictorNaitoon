// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int numeroAInvertir, auxiliar, eleccion;
do
{
    Console.WriteLine("Ingrese el numero que desea invertir: ");
    numeroAInvertir = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("El numero invertido es: ");
    while (numeroAInvertir != 0){
        auxiliar = numeroAInvertir % 10;
        Console.Write(auxiliar);
        numeroAInvertir = numeroAInvertir/10;
    }

    Console.WriteLine(" ");

    Console.WriteLine("Desea invertir otro numero (1:SI 0:NO)");
    eleccion = Convert.ToInt16(Console.ReadLine());
} while (eleccion !=0 );


