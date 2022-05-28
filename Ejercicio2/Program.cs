Console.WriteLine("Calculadora Version 1 sin la libreria Math");

int eleccion1, eleccion2, numero1, numero2;
double resultado;

do
{
    Console.WriteLine("¿Que operacion desea realizar?");
    Console.WriteLine("1- Suma. ");
    Console.WriteLine("2- Resta. ");
    Console.WriteLine("3- Multiplicar. ");
    Console.WriteLine("4- Dividir. ");
    eleccion1 = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Ingrese el primer numero: ");
    numero1 = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero: ");
    numero2 = Convert.ToInt16(Console.ReadLine());

    switch (eleccion1){
        case 1:
            resultado = numero1 + numero2;
            Console.WriteLine("El resultado es: "+resultado);
            break;
        case 2:
            resultado = numero1 - numero2;
            Console.WriteLine("El resultado es: "+resultado);
            break;
        case 3:
            resultado = numero1 * numero2;
            Console.WriteLine("El resultado es: "+resultado);
            break;
        case 4:
            if (numero2 != 0){
                resultado = numero1 / numero2;
                Console.WriteLine("El resultado es: "+resultado);
            } else{
                Console.WriteLine("No se puede dividir por un numero igual a cero (0)");
            }
            break;
        default:
            Console.WriteLine("Ingrese una opción  valida");
            break;
    }

    Console.WriteLine("Desea realizar alguna otra operacion operacion (1:SI, 0:NO)");
    eleccion2 = Convert.ToInt16(Console.ReadLine());

} while (eleccion2 != 0);