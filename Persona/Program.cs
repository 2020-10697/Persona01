using System;

namespace Persona
{
    class Persona
    {
        //Crear una clase Persona que tenga como atributos el "cedula, nombre, apellido y la edad (definir las propiedades 
        //para poder acceder a dichos atributos)". Definir como responsabilidad un método para mostrar ó imprimir.Crear una
        //segunda clase Profesor que herede de la clase Persona.Añadir un atributo sueldo(y su propiedad) y el método 
        //para imprimir su sueldo.Definir un objeto de la clase Persona y llamar a sus métodos y propiedades.También crear 
        //un objeto de la clase Profesor y llamar a sus métodos y propiedades.

        private string nombre;
        private string apellido;
        private string cedula;
        private int edad;
        public Persona()
        {
            Console.Write("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su apellido:");
            apellido = Console.ReadLine();
            Console.Write("Ingrese su cedula:");
            cedula = Console.ReadLine();
            Console.Write("Ingrese su edad:");
            string ed = Console.ReadLine();
            edad = int.Parse(ed);
        }
        public void imprimir()
        {
            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Cedula: " + cedula);
            Console.WriteLine("Edad: " + edad);
        }
        class Profesor
        {
            private double sueldo;
            public Profesor()
            {
                sueldo = 50000;
            }
            public void imprimir()
            {
                Console.WriteLine("Su sueldo es de: " + sueldo);
               
            }
        }
        static void Main(string[] args)
        {
            Persona person = new Persona();
            Profesor prof = new Profesor();
            person.imprimir();
            prof.imprimir();
        }
    }
}

