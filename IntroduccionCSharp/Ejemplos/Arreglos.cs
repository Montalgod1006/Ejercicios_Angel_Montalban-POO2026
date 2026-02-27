using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroduccionCSharp.Ejemplos
{
    public class Arreglos
    {
        public int[] Numbers { get; set; }
        public int CurrentPosition {get; set;}
        //ctor
         public void StartArreglos (int tamaño)
        {
            Numbers = new int [tamaño];
            CurrentPosition = 0;
            Console.WriteLine("Presione Cualquier Tecla para Continuar ...");
            Console.ReadLine();
        }
        public void AddValue (int number)
        {
           Numbers[CurrentPosition] = number;
           CurrentPosition++;
        }
        public void Print()
        {
            for (int i = 0; i < Numbers.Length; i++) //.Length es para recibir el tamaño del arreglo
            {
                Console.WriteLine(i + ":" + Numbers[i]);
            }
            Console.WriteLine("Presione Cualquier Tecla para Continuar ...");
            Console.ReadLine();
        }
    }
}
            //El + sirve para concatenar
            //carros.Length este comando sirve para ver el tamaño del arreglo