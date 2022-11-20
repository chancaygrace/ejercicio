using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
   class Profesores : Persona {
        public string departamento;
        public Profesores(string departamento , Datos Profe):base (departamento, Profe)
        {
            this.departamento = departamento;

        }

        }
    
}
