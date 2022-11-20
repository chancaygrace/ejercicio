using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
     class Empleados: Persona
    {

        public int numerodespacho;
        public int añoincorporacion;

        public Empleados(int añoincorporacion, int numerodespacho, Datos emple) : base(añoincorporacion, numerodespacho, emple)
        {
        }

        public Empleados(int añoincorporacion, Datos emple, int numerodespacho, Persona personas ): base(añoincorporacion, emple)        
        {
            this.añoincorporacion = añoincorporacion;
            this.numerodespacho = numerodespacho;


        }
    }
}

