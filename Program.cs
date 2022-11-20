// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Estudiantes estudiantes = new Estudiantes(10 , new Datos(" Grace ", "Chancay ", "Soltero", 1315763852));
            Empleados empleados = new Empleados(2020, 123 , new Datos(" mariela ", "Tumbaco ", "Soltero", 1316269347));
            Profesores profesor = new Profesores("Matematicas" , new Datos ("Fatima ", "Moreira ", "Soltero", 1315152510));
            Datos estudiantes1 = new Datos(" Dilan ", "Bonilla" , "a" , 123);
            
            estudiantes.ImprimirPersona();

        }
    }
}

