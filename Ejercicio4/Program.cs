// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string cadena1, cadena2, cadenaAuxiliar;

do
{
    Console.WriteLine("Por favor, ingrese una cadena de caracteres: ");
    cadena1 = Console.ReadLine();
} while (cadena1.Length == 0);

if (cadena1.Length > 2){
    Console.WriteLine($"Algunas letras que tiene la cadena ingresada son: {cadena1[0]} {cadena1[2]}");   
} else {
    Console.WriteLine($"Letra que contiene la cadena ingresada: {cadena1[0]}");
}

Console.WriteLine("La longitud de la cadena ingresada es: "+cadena1.Length);

do
{
    Console.WriteLine("Por favor, ingrese una segunda cadena de caracteres: ");
    cadena2 = Console.ReadLine();
} while (cadena2.Length == 0);

cadenaAuxiliar = cadena1+" "+ cadena2;

Console.WriteLine("Las dos cadenas unidas: "+cadenaAuxiliar);

Console.WriteLine("Una subcadena de la dos cadenas unidas: "+cadenaAuxiliar.Substring(cadena1.Length));


//CALCULADORA
Console.WriteLine("CALCULADORA");

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
            Console.WriteLine("La suma de "+numero1+" y de "+numero2+" es: "+resultado);
            break;
        case 2:
            resultado = numero1 - numero2;
            Console.WriteLine("La resta de "+numero1+" y de "+numero2+" es: "+resultado);
            break;
        case 3:
            resultado = numero1 * numero2;
            Console.WriteLine("La multiplicacion de "+numero1+" y de "+numero2+" es: "+resultado);
            break;
        case 4:
            if (numero2 != 0){
                resultado = numero1 / numero2;
                Console.WriteLine("La division de "+numero1+" y de "+numero2+" es: "+resultado);
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

Console.WriteLine("Recorrido de la primera cadena ingresada a traves de un foreach");
foreach (char letra in cadena1){
    Console.Write(letra+" ");
}

Console.Write("\n");
Console.WriteLine("Ingrese la palabra que desea buscar en la primera cadena ingresada: ");
string palabra = Console.ReadLine();
Console.WriteLine($"¿La palabra {palabra} pertenece a la cadena? "+cadena1.Contains(palabra));

Console.WriteLine("La cadena1 transformada en mayusculas es: ");
Console.WriteLine(cadena1.ToUpper());
Console.WriteLine("La cadena1 transformada en minusculas es: ");
Console.WriteLine(cadena1.ToLower());

Console.WriteLine("Comparacion de la primera cadena ingresada y la segunda cadena ingresada");
Console.WriteLine(String.Equals(cadena1,cadena2));

Console.WriteLine("Ingrese una cadena separada por los caracteres - en lugar de espacio");
string cadena3 = Console.ReadLine();
string[] cadenaSeparada = cadena3.Split("-");
foreach (string frase in cadenaSeparada){
    Console.Write(frase+" ");
}
Console.Write("\n");

Console.WriteLine("Ingrese una ecuacion simple con solo una multiplicacion, una division, una resta o una suma");
string ecuacion = Console.ReadLine();

if (ecuacion.Contains("+")){
    Console.WriteLine("El resultado es: "+(Convert.ToDouble(ecuacion.Split("+")[0])+Convert.ToDouble(ecuacion.Split("+")[1])));
} else{
    if (ecuacion.Contains("-")){
        Console.WriteLine("El resultado es: "+(Convert.ToDouble(ecuacion.Split("-")[0])-Convert.ToDouble(ecuacion.Split("-")[1])));
    } else{
        if (ecuacion.Contains("*")){
            Console.WriteLine("El resultado es: "+(Convert.ToDouble(ecuacion.Split("*")[0])*Convert.ToDouble(ecuacion.Split("*")[1])));
        } else{
            if (ecuacion.Contains("/")){
                if (Convert.ToDouble(ecuacion.Split("/")[1]) == 0){
                    Console.WriteLine("Error, no se puede dividir un numero por cero 0");
                } else {
                    Console.WriteLine("El resultado es: "+(Convert.ToDouble(ecuacion.Split("/")[0])/Convert.ToDouble(ecuacion.Split("/")[1])));
                }
            }
        }
    }
}