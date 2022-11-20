using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Persona
    {
        int cursoMatriculado;
        Datos estudiante1;
         
        Datos emple;
         int numerodespacho;
         int añoincorporacion;
        string departamento;
        Datos profe;
        Datos Servicio;
        string seccion;

        public Persona(int cursoMatriculado, Datos estudiante1)
        {
            this.cursoMatriculado = cursoMatriculado;
            this.estudiante1 = estudiante1;
            
        }

        public Persona(string departamento, Datos profe)
        {
            this.departamento = departamento;
            this.profe = profe;
        }

        public Persona(int añoincorporacion, int numerodespacho, Datos emple)
        {
            this.añoincorporacion = añoincorporacion;
            this.numerodespacho = numerodespacho;

        }

        public void ImprimirPersona()
        {
           
            Console.WriteLine("Estudiante: " +"Materias matriculadas:"  + cursoMatriculado + " Nombres: " + estudiante1.Nombres + " Apellidos: " + estudiante1.Apellidos + " idPersona: " + estudiante1.idPersona + " Estado Civil: " + estudiante1.EstadoCivil);
            Console.Write("Empleado: " + " año incorporación : " + añoincorporacion + " numero despacho: " + numerodespacho + " Nombres: " + emple.Nombres + " Apellidos: " + emple.Apellidos + " idPersona: " + emple.idPersona + " Estado Civil " + emple.EstadoCivil);
            Console.WriteLine("Profe: " + "Departamento:" + departamento + " Nombres: " + profe.Nombres + " Apellidos: " + profe.Apellidos + " idPersona: " + profe.idPersona + " Estado Civil: " + profe.EstadoCivil);
        }

    }
}
