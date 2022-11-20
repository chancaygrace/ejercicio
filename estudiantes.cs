using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Estudiantes : Persona
    {
        public int CursoMatriculado;


        public Estudiantes(int CursoMatriculado, Datos estudiante1): base(CursoMatriculado, estudiante1)
        {
            this.CursoMatriculado = CursoMatriculado;
        }
    }
}
