using IntroduccionCSharp.Ejemplos;

Calculadora calculadora = new Calculadora();

Console.WriteLine("==== SUMAR ====");
Console.WriteLine("");
string operacion = "";
int n1 = 0;
int n2 = 0;
/*Recordar que en c# a diferencia de c++ no se puede poner directamente int, lo mas cercano seria hacer
int n1 = in.Parse(Console.ReadLine());*/
// ctrl + tab y alt + flechitas

try
{
    Console.WriteLine("Que operación quiere realizar, se permite (+, -, x, ÷)");
    operacion = Console.ReadLine();

    Console.WriteLine("Ingrese el primer numero ");
    n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero ");
    n2 =  int.Parse(Console.ReadLine());
}
catch
{
    Console.WriteLine("Error de formato en el texto ingresado");
}
int resultado;
switch (operacion)
{
    case "+":
        resultado = calculadora.sumar(n1,n2);
    break;
    case "-":
        resultado = calculadora.restar(n1,n2);
    break;
    case "x":
        resultado = calculadora.Multiplicar(n1,n2);
    break;
    case"÷":
        resultado = calculadora.dividir(n1,n2);
    break;
    default:
    throw new Exception("No ingreso una operación valida INDIO");
}

Console.WriteLine("El resultado es: " + resultado);
/*Persona persona1 = new Persona("Angel","Montalban","M",20);
Console.WriteLine("Hola " + persona1.Nombre +" " +persona1.Apellidos +
 " usted tiene " + persona1.Edad + " Años" );*/
/*class Program
{
    static void Main()
    {
        Console.WriteLine("Hola mundo");
        Console.WriteLine ("¿Como te llamas?");
        string nombre = Console.ReadLine();
        Console.WriteLine("¿Que edad tienes?");
        string edad = Console.ReadLine();

        Console.WriteLine("\nHola " + nombre +" Tienes "+ edad + "años.");
    }
}*/