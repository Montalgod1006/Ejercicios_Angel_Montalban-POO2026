using IntroduccionCSharp.Ejemplos;


//To Do: Solo ingresar valores positivos
Arreglos arreglos = new Arreglos();
string Op = "";
int tamaño = 0, Arr = 0;
do
{
    Console.Clear();
    Console.WriteLine("-----MENU-----");
    Console.WriteLine("\n1.Crear el arreglo\n2.Ingresar un valor en el arreglo\n3. Imprimir el arreglo\n4. Salir");
    Op = Console.ReadLine();
    //int num = 0;
    switch (Op)
    {
        case "1":
            do
            {
                Console.WriteLine("Ingrese el tamaño del arreglo");
                 tamaño = int.Parse( Console.ReadLine());
                if(tamaño <= 0)
                {
                    Console.WriteLine("Error, Tamaño no valido");
                }
            } while (tamaño <= 0);
            Arr = 1;
            arreglos.StartArreglos(tamaño);
        break;
        case "2":
                if(Arr == 0|| arreglos.CurrentPosition >= tamaño)
                {
                    Console.WriteLine("Error, Arreglo no inicializado o Arreglo Lleno\nPresione Cualquier Tecla para Continuar");
                    Console.ReadLine();
                }
                else
                {
                    for (int i = 0; i < tamaño  ; i++)
                    {
                        Console.WriteLine("Ingrese el valor n"+ (i+1) +": ");
                        int num = int.Parse(Console.ReadLine());
                        if (num%2 == 0)
                        {
                            arreglos.AddValue(num);
                        }
                        else
                        {
                            Console.WriteLine("Solo se aceptan valores positivos");
                            i--;
                        }
                    }
                }
        break;
        case "3":
            if(Arr==0)
            {
                 Console.WriteLine("Error, Arreglo no inicializado\nPresione Cualquier Tecla para Continuar");
                Console.ReadLine();
            }
            else
            {
                arreglos.Print();
            }
        break;
        case "4":
                Console.Clear();
                Console.WriteLine("Adios");
        break;
        default:
                Console.WriteLine("Comando incorrecto\n");
        break;
        
    }
} while (Op != "4");
//Menu: 
//1.Crear el arreglo 
//2. Ingresar un valor en el arreglo
//3. Imprimir el arreglo
//4. Salir
// Hacer un do while




/*Calculadora calculadora = new Calculadora();

Console.WriteLine("==== SUMAR ====");
Console.WriteLine("");
string operacion = "";
int n1 = 0;
int n2 = 0;*/
/*Recordar que en c# a diferencia de c++ no se puede poner directamente int, lo mas cercano seria hacer
int n1 = in.Parse(Console.ReadLine());*/
// ctrl + tab y alt + flechitas
/*
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
*/
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