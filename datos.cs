using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Datos
    {
        public string EstadoCivil;
        public string Nombres;
        public string Apellidos;
        public int idPersona;


        public Datos(string Nombres, string Apellidos, string EstadoCivil, int idPersona)
        {
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.idPersona = idPersona;
            this.EstadoCivil = EstadoCivil;

        }


    }
}
