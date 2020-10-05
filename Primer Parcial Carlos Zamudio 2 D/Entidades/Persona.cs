using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Apellido
        {
            set { apellido = value; }
            get { return apellido; }
        }

        public int Dni
        {
            set { dni = value; }
            get { return dni; }
        }

        public Persona(string p_nombre, string p_apellido, int p_dni)
        {
            this.nombre = p_nombre;
            this.apellido = p_apellido;
            this.dni = p_dni;
        }

        public abstract string Mostrar();

    }
}
