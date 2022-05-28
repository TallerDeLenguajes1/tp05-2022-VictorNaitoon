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

Console.WriteLine("Calculadora version 2 con la libreria Math");

int eleccion3;
double numero3, numero4;
Console.WriteLine("Ingrese un tercer numero: ");
numero3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"El valor absoluto del tercer numero es: {Math.Abs(numero3)}");
Console.WriteLine("El cuadrado del tercer numero es: "+Math.Pow(numero3,2));
Console.WriteLine($"La raiz cuadrada del tercer numero es: {Math.Sqrt(numero3)}");
Console.WriteLine($"El seno de el tercer numero es: {Math.Sin(numero3)}");
Console.WriteLine($"El coseno del tercer numero es: {Math.Cos(numero3)}");
Console.WriteLine($"La parte entera del float es: {Math.Truncate(numero3)}");

Console.WriteLine("Ingrese un cuarto numero: ");
numero4 = Convert.ToDouble(Console.ReadLine());
do
{
    Console.WriteLine("Que operacion desea realizar: ");
    Console.WriteLine("1 - Obtener el maximo.");
    Console.WriteLine("2 - Obtener el minimo.");
    eleccion3 = Convert.ToInt16(Console.ReadLine());
    switch (eleccion3){
        case 1:
            if (numero3 > numero4){
                Console.WriteLine("El tercer numero de valor: "+Convert.ToDouble(numero3)+" es el mayor");
            } else{
                if (numero4 > numero3){
                    Console.WriteLine("El cuarto numero de valor: "+Convert.ToDouble(numero4)+" es el mayor");
                } else{
                    Console.WriteLine("Los numeros son iguales");
                }
            }
            break;
        case 2:
            if (numero3 == numero4){
                Console.WriteLine("Los numeros son iguales");
            } else{
                if (numero3 > numero4){
                    Console.WriteLine("El cuarto numero de valor: "+Convert.ToDouble(numero4)+" es el menor");
                }else{
                    Console.WriteLine("El tercer numero de valor: "+Convert.ToDouble(numero3)+" es el menor");
                }
            }
            break;
        default:
            Console.WriteLine("Ingrese un valor valido");
            break;
    }

    Console.WriteLine("Desea realizar otra operacion (1:SI 0:NO)");
    eleccion3 = Convert.ToInt16(Console.ReadLine());
} while (eleccion3 != 0);