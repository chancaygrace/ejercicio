using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class PersonalServicio: Persona
    {
        string seccion;

        public PersonalServicio(string seccion, Datos Servicio): base(seccion, Servicio)
        {
            this.seccion=seccion;
        }
    }
}
