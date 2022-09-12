using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//•Instrucciones

//1.Crea un Proyecto de tipo consola de nombre Practica_2

//2.Deberas:

//Declarar una variable de tipo int llamada “Edad”
//Declarar una variable de tipo string llamada: “Nombre”
//Declarar una variable de tipo string llamada: “Pais”
//Inicializar las 3 variables
//Imprimir el siguiente mensaje concatenando las variables:
//Mi nombre es: “Nombre”, tengo “Edad” de edad y me gustaria conocer el pais de “Pais”
//3.Sube tu codigo a GitHub

//4.Copia-pega el link de tu repositorio en la actividad asignada en Blackboard


namespace Practica_2


{
    internal class Program
    

    {
        static void Main(string[] args)
        {
            int edad = 21;
            string nombre = "Jose Alfredo Murillo Salazar";
            string pais = "Mexico";

            string concat = + edad  + nombre + pais ;
            Console.WriteLine(concat);
        }
    }
}
